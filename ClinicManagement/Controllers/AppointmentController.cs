﻿using AutoMapper;
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
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AppointmentController(ApplicationDbContext context, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
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
        public IActionResult Create()
        {
            var specialties = _context.Specialties;
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);

            var model = new AppointmentCreateViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(AppointmentCreateViewModel model)
        {
            if(model.SpecialtyId != null && model.DoctorId != null)
            {
                var doctor = _context.Users.Single(u => u.Id.Equals(model.DoctorId));
                model.Doctor = _mapper.Map<DoctorViewModel>(doctor);

                var specialty = _context.Specialties.Single(s => s.SpecialtyId.Equals(model.SpecialtyId));
                model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);
            }
            return View(model);
        }

        public async Task<JsonResult> AllDoctorsInSpecialty(int specialtyId)
        {
            var doctors = await _context.Users.Where(u => u.UserSpecialties.Any(us => us.SpecialtyId == specialtyId)).ToListAsync();
            var doctorsVM = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors);
            return Json(doctorsVM);
        }

        public async Task<JsonResult> AllSpecialties()
        {
            var specialties = await _context.Specialties.ToListAsync();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);
            return Json(specialtiesVM);
        }
    }
}
