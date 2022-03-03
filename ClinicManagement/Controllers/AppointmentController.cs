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
        public async Task<IActionResult> Availability()
        {
            var specialties = await _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);

            var model = new AvailabilityGetViewModel();
            return View("AvailabilityGet",model);
        }

        [HttpPost]
        public async Task<IActionResult> Availability(AvailabilityGetViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doctor = await _userManager.FindByIdAsync(model.DoctorId);
                model.Doctor = _mapper.Map<DoctorViewModel>(doctor);

                var specialty = await _unitOfWork.Specialties.FindOneAsync(s => s.Id == model.SpecialtyId);
                model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);

                var newModel = _mapper.Map<AvailabilityPostViewModel>(model);
                return View("AvailabilityPost", newModel);
            }
            return View("AvailabilityPost", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AvailabilityPostViewModel model)
        {
            var specialty = await _unitOfWork.Specialties.GetById((long)model.SpecialtyId);
            var doctor = await _userManager.FindByIdAsync(model.DoctorId);

            if (ModelState.IsValid)
            {
                var hour = await _unitOfWork.AppointmentHours.FindOneAsync(h => h.Hour.Equals(model.Hour));
                var patient = await _userManager.GetUserAsync(HttpContext.User);

                var newAppointment = new Appointment();
                newAppointment.Patient = patient;
                newAppointment.Doctor = doctor;
                newAppointment.Date = DateTime.Parse(model.Date);
                newAppointment.Hour = hour;
                newAppointment.CreateDate = DateTime.Now;
                newAppointment.ModificationDate = null;

                _unitOfWork.Appointments.Insert(newAppointment);
                if(await _unitOfWork.SaveChangesAsync() < 1)
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View("AvailabilityPost", model);
                }

                return View(model);
            }

            model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);
            model.Doctor = _mapper.Map<DoctorViewModel>(doctor);

            return View("AvailabilityPost", model);
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

        public async Task<JsonResult> DoctorAvailability(string doctorId, DateTime date)
        {
            var appointmentHours = await _unitOfWork.AppointmentHours.GetAll();
            var appointmentHoursVM = _mapper.Map<IEnumerable<AppointmentHourViewModel>>(appointmentHours);

            var doctorAppointments = await _unitOfWork.Appointments.FindAsync(a => a.DoctorId.Equals(doctorId) && a.Date.Date.CompareTo(date.Date) == 0);
            var doctorAppointmentsHoursId = doctorAppointments.Select(a => a.AppointmentHourId);

            for (int i = 0; i < appointmentHoursVM.Count(); i++)
            {
                if (!doctorAppointmentsHoursId.Contains(appointmentHoursVM.ElementAt(i).HourId))
                    appointmentHoursVM.ElementAt(i).Availability = true;
            }

            return Json(appointmentHoursVM);
        }
    }
}
