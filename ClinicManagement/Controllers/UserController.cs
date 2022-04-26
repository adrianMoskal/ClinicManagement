using AutoMapper;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostEnvironment;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager, IMapper mapper, IHostingEnvironment hostEnvironment)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Doctor,Patient")]
        public async Task<IActionResult> Profile()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var user = _mapper.Map<UserProfileViewModel>(currentUser);

            return View(user);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Patient")]
        public async Task<IActionResult> Doctors()
        {
            var users = await _userManager.GetUsersInRoleAsync("Doctor");
            var doctors = _mapper.Map<IEnumerable<DoctorViewModel>>(users);

            return View(doctors);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator,Doctor")]
        public async Task<IActionResult> Patients()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var patients = currentUser.AppointmentsDoc.Select(a => a.Patient).Distinct();
            var patientsVM = _mapper.Map<IEnumerable<PatientViewModel>>(patients);

            _hostEnvironment.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            foreach (var patient in patientsVM)
            {
                string path = string.Format("{0}/img/profiles/{1}.jpg", _hostEnvironment.WebRootPath, patient.UserName);

                patient.PhotoUploaded = System.IO.File.Exists(path) ? true : false;
            }


            return View(patientsVM);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Panel()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Manage()
        {
            var usersDb = await _userManager.Users.ToListAsync();
            var users = _mapper.Map<IEnumerable<UserViewModel>>(usersDb);

            return View(users);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(string userId)
        {
            var userDb = await _userManager.FindByIdAsync(userId);

            var user = _mapper.Map<UserEditViewModel>(userDb);

            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(UserEditViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var userDb = await _userManager.FindByIdAsync(userViewModel.UserId);
                if (userDb != null)
                {
                    userDb.UserName = userViewModel.UserName;
                    userDb.FirstName = userViewModel.FirstName;
                    userDb.LastName = userViewModel.LastName;
                    userDb.PhoneNumber = userViewModel.PhoneNumber;

                    var result = await _userManager.UpdateAsync(userDb);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Manage");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                    }
                }
            }

            return View(userViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (await _userManager.IsInRoleAsync(user, "Administrator"))
            {
                return RedirectToAction("Manage");
            }

            await _userManager.DeleteAsync(user);

            return RedirectToAction("Manage");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> ManageRoles()
        {
            var usersDb = await _userManager.Users.ToListAsync();

            var model = new UserEditRoleViewModel();
            model.Users = _mapper.Map<IEnumerable<UserViewModel>>(usersDb);

            var roles = await _roleManager.Roles.ToListAsync();
            var rolesVM = _mapper.Map<IEnumerable<RoleViewModel>>(roles);

            model.Roles = new SelectList(rolesVM, "RoleId", "Name");

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> ManageRoles(string userId, string roleId)
        {
            var usersDb = await _userManager.Users.ToListAsync();

            var x = await _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToListAsync();

            var model = new UserEditRoleViewModel();
            model.Users = _mapper.Map<IEnumerable<UserViewModel>>(usersDb);

            var roles = await _roleManager.Roles.ToListAsync();
            var rolesVM = _mapper.Map<IEnumerable<RoleViewModel>>(roles);

            model.Roles = new SelectList(rolesVM, "RoleId", "Name");

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userId);
                
                if (user is null)
                {
                    ModelState.AddModelError(string.Empty, "User not found");
                    return View(model);
                }

                var role = await _roleManager.FindByIdAsync(roleId);

                if (role is null)
                {
                    ModelState.AddModelError(string.Empty, "Role not found");
                    return View(model);
                }

                var userRoles = await _userManager.GetRolesAsync(user);
                var result = await _userManager.RemoveFromRolesAsync(user, userRoles.ToArray());

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return View(model);
                }

                result = await _userManager.AddToRoleAsync(user, role.Name);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return View(model);
                }

                var userVM = _mapper.Map<UserViewModel>(user);
                model.Users = model.Users.Select(u => u.UserId.Equals(user.Id) ? userVM : u);

                TempData["roleChanged"] = true;
            }

            return View(model);
        }
    }
}
