using AutoMapper;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Controllers
{
    [Authorize]
    public class PrescriptionController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public PrescriptionController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var userPrescriptions = currentUser.PrescriptionsDoc.Any() ? currentUser.PrescriptionsDoc : currentUser.PrescriptionsPat;

            var prescriptions = _mapper.Map<IEnumerable<PrescriptionViewModel>>(userPrescriptions);
            prescriptions = prescriptions.OrderByDescending(a => a.CreateDate);

            return View(prescriptions);
        }
    }
}
