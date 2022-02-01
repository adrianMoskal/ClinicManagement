using AutoMapper;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Controllers
{
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
        public async Task<IActionResult> Doctors()
        {
            var users = await _userManager.GetUsersInRoleAsync("Doctor");

            var doctors = _mapper.Map<IEnumerable<DoctorViewModel>>(users);

            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> Patients()
        {
            var users = await _userManager.GetUsersInRoleAsync("Patient");

            var patients = _mapper.Map<IEnumerable<PatientViewModel>>(users);

            return View(patients);
        }

        [HttpGet]
        public IActionResult Panel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var usersDb = _userManager.Users;
            var users = _mapper.Map<IEnumerable<UserViewModel>>(usersDb);

            return View(users);
        }

        [HttpGet]
        public IActionResult Edit(string userId)
        {
            var userDb = _userManager.Users.SingleOrDefault(u => u.Id.Equals(userId));
            var user = _mapper.Map<UserEditViewModel>(userDb);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var userDb = _userManager.Users.SingleOrDefault(u => u.Id.Equals(userViewModel.UserId));
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
        public async Task<IActionResult> Delete(string userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id.Equals(userId));
            await _userManager.DeleteAsync(user);

            return RedirectToAction("Manage");
        }

    }
}
