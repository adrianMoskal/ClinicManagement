using AutoMapper;
using ClinicManagement.Data;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMapper _mapper;

        public AppointmentController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var currentUser = _context.Users.SingleOrDefault(u => u.UserName.Equals(User.Identity.Name));

            var userAppointments = currentUser.AppointmentsDoc.Any() ? currentUser.AppointmentsDoc : currentUser.AppointmentsPat;

            var appointments = _mapper.Map<IEnumerable<AppointmentViewModel>>(userAppointments);

            return View(appointments);
        }
    }
}
