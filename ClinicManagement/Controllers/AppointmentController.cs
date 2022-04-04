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
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public AppointmentController(IUnitOfWork unitOfWork, UserManager<User> userManager, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var userAppointments = currentUser.AppointmentsDoc.Any() ? currentUser.AppointmentsDoc : currentUser.AppointmentsPat;

            var appointments = _mapper.Map<IEnumerable<AppointmentViewModel>>(userAppointments);

            return View(appointments);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var specialties = await _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);

            var model = new AppointmentCreateViewModel();
            model.Specialties = new SelectList(specialtiesVM, "SpecialtyId", "Name");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("SpecialtyId", "DoctorId", "Date", "HourId")] AppointmentCreateViewModel model)
        {
            var specialties = await _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);
            model.Specialties = new SelectList(specialtiesVM, "SpecialtyId", "Name");

            if (ModelState.IsValid)
            {
                var doctor = await _userManager.FindByIdAsync(model.DoctorId);

                if (doctor is null)
                {
                    ModelState.AddModelError("DoctorId", "Doctor 404");
                    return View(model);
                }

                if (doctor.AppointmentsDoc.Any(a => a.Date == model.Date && a.AppointmentHourId == model.HourId))
                {
                    ModelState.AddModelError("HourId", "This hour is taken");
                    return View(model);
                }

                var specialty = await _unitOfWork.Specialties.GetById(model.SpecialtyId);

                if (specialty is null)
                {
                    ModelState.AddModelError("SpecialtyId", "Specialty 404");
                    return View(model);
                }

                var hour = await _unitOfWork.AppointmentHours.GetById(model.HourId);

                if (hour is null)
                {
                    ModelState.AddModelError("HourId", "Hour 404");
                    return View(model);
                }

                var newAppointment = _mapper.Map<Appointment>(model);
                newAppointment.Patient = await _userManager.GetUserAsync(HttpContext.User);
                _unitOfWork.Appointments.Insert(newAppointment);

                if(await _unitOfWork.SaveChangesAsync() < 1)
                {
                    ModelState.AddModelError("", "Error while creating appointment");
                    return View(model);
                }

                model.Doctor = _mapper.Map<DoctorViewModel>(doctor);
                model.Patient = _mapper.Map<PatientViewModel>(newAppointment.Patient);
                model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);
                model.Hour = _mapper.Map<AvailableHourViewModel>(hour);

                return View("AppointmentCreated", model);
            }
            return View(model);
        }

        public async Task<JsonResult> AllSpecialties()
        {
            var specialties = await _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);
            return Json(specialtiesVM);
        }

        public async Task<JsonResult> AllDoctorsInSpecialty(int specialtyId)
        {
            var doctors = await _userManager.Users.Where(u => u.UserSpecialties.Any(us => us.SpecialtyId == specialtyId)).ToListAsync();
            var doctorsVM = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors);
            return Json(doctorsVM);
        }

        public async Task<JsonResult> HoursAvailability(string doctorId, DateTime date)
        {
            var appointmentHours = await _unitOfWork.AppointmentHours.GetAll();
            var appointmentHoursVM = _mapper.Map<IEnumerable<AvailableHourViewModel>>(appointmentHours);

            var doctorAppointments = await _unitOfWork.Appointments.FindAsync(a => a.DoctorId.Equals(doctorId) && a.Date.Date.CompareTo(date.Date) == 0);
            var doctorAppointmentsHoursId = doctorAppointments.Select(a => a.AppointmentHourId);

            for (int i = 0; i < appointmentHoursVM.Count(); i++)
            {
                if (!doctorAppointmentsHoursId.Contains(appointmentHoursVM.ElementAt(i).HourId))
                    appointmentHoursVM.ElementAt(i).Available = true;
            }

            return Json(appointmentHoursVM);
        }
    }
}
