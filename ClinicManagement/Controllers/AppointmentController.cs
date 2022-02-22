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

        public AppointmentController(UnitOfWork unitOfWork, UserManager<User> userManager, IMapper mapper)
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
        public IActionResult Availability()
        {
            var specialties = _unitOfWork.Specialties.GetAll();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);

            var model = new AppointmentCreateViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Availability(AppointmentCreateViewModel model)
        {
            if(model.SpecialtyId != null && model.DoctorId != null)
            {
                var doctor = _userManager.Users.Single(u => u.Id.Equals(model.DoctorId));
                model.Doctor = _mapper.Map<DoctorViewModel>(doctor);

                // change
                var specialty = _unitOfWork.Specialties.GetAll().Single(s => s.Id.Equals(model.SpecialtyId));
                model.Specialty = _mapper.Map<SpecialtyViewModel>(specialty);
            }
            return View(model);
        }

        public JsonResult AllSpecialties()
        {
            var specialties =  _unitOfWork.Specialties.GetAll().ToList();
            var specialtiesVM = _mapper.Map<IEnumerable<SpecialtyViewModel>>(specialties);
            return Json(specialtiesVM);
        }

        public async Task<JsonResult> AllDoctorsInSpecialty(int specialtyId)
        {
            var doctors = await _userManager.Users.Where(u => u.UserSpecialties.Any(us => us.SpecialtyId == specialtyId)).ToListAsync();
            var doctorsVM = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors);
            return Json(doctorsVM);
        }

        public JsonResult DoctorAvailability(string doctorId, DateTime date)
        {
            var appointmentHours = _unitOfWork.AppointmentHours.GetAll().ToList();
            var appointmentHoursVM = _mapper.Map<List<AppointmentHourViewModel>>(appointmentHours);

            // change
            var doctorAppointments = _unitOfWork.Appointments.GetAll().Where(a => a.DoctorId.Equals(doctorId) && a.Date.Date.CompareTo(date.Date) == 0).Select(a => a.AppointmentHourId);

            for (int i = 0; i < appointmentHoursVM.Count(); i++)
            {
                if (!doctorAppointments.Contains(appointmentHoursVM[i].HourId))
                    appointmentHoursVM[i].Availability = true;
            }

            return Json(appointmentHoursVM);
        }
    }
}
