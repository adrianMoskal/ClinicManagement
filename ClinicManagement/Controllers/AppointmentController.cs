using AutoMapper;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AppointmentController(ApplicationDbContext context, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var currentUser = _context.Users.SingleOrDefault(u => u.UserName.Equals(User.Identity.Name));

            var userAppointments = currentUser.AppointmentsDoc.Any() ? currentUser.AppointmentsDoc : currentUser.AppointmentsPat;

            var appointments = _mapper.Map<IEnumerable<AppointmentViewModel>>(userAppointments);

            return View(appointments);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctors = await _userManager.GetUsersInRoleAsync("Doctor");
            var doctorsVM = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors);

            var model = new AppointmentCreateViewModel();
            model.Doctors = new SelectList(doctorsVM, "DoctorId", "FullName");

            return View(model);
        }

        [HttpPost]
        public string Create(AppointmentCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(model.DoctorId != null)
                {
                    var doctor = _context.Users.Single(u => u.Id.Equals(model.DoctorId));
                    return doctor.FirstName + doctor.LastName;
                }
            }
            return "Test";
           
        }
    }
}
