using AutoMapper;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
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
            var users = await _userManager.GetUsersInRoleAsync("Patient");
            var patients = _mapper.Map<IEnumerable<PatientViewModel>>(users);

            return View(patients);
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

            for(int i = 0; i < users.Count(); i++)
            {
                var roles = await _userManager.GetRolesAsync(usersDb.ElementAt(i));
                users.ElementAt(i).Role = string.Join(", ", roles);
            }

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
    }
}
