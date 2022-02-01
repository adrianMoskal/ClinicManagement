using AutoMapper;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using ClinicManagement.Repositories;
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
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        private readonly UserManager<User> _userManager;
        
        public UserController(UserManager<User> userManager, IMapper mapper, IUserRepository userRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _userRepository = userRepository;
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
            var usersDb = _userRepository.GetAll();
            var users = _mapper.Map<IEnumerable<UserViewModel>>(usersDb);

            return View(users);
        }

    }
}
