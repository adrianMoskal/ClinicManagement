using AutoMapper;
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

        public async Task<IActionResult> Doctors()
        {
            var users = await _userManager.GetUsersInRoleAsync("Doctor");

            var doctors = _mapper.Map<IEnumerable<DoctorViewModel>>(users);

            return View(doctors);
        }
    }
}
