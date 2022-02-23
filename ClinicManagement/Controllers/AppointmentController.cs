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
        public IActionResult Index()
        {
            var currentUser = _userManager.Users.SingleOrDefault(u => u.UserName.Equals(User.Identity.Name));

            var userAppointments = currentUser.AppointmentsDoc.Any() ? currentUser.AppointmentsDoc : currentUser.AppointmentsPat;

            var appointments = _mapper.Map<IEnumerable<AppointmentViewModel>>(userAppointments);

            return View(appointments);
        }

        [HttpGet]
        public async Task<IActionResult> Availability()
        {
            var specialties = await _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);

            var model = new AppointmentCreateViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Availability(AppointmentCreateViewModel model)
        {
            if (model.SpecialtyId != null && model.DoctorId != null)
            {
                var doctor = _userManager.Users.Single(u => u.Id.Equals(model.DoctorId));
                model.Doctor = _mapper.Map<DoctorViewModel>(doctor);

                var specialty = await _unitOfWork.Specialties.FindOneAsync(s => s.Id == model.SpecialtyId);
                model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);
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
