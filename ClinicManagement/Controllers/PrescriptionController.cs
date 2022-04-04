using AutoMapper;
using ClinicManagement.Data;
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
        private readonly IUnitOfWork _unitOfWork;

        public PrescriptionController(UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            IEnumerable<Prescription> userPrescriptions = null;
            if (await _userManager.IsInRoleAsync(currentUser, "Pharmacist"))
            {
                userPrescriptions = await _unitOfWork.Prescriptions.GetAll();
            }
            else
            {
                userPrescriptions = currentUser.PrescriptionsDoc.Any() ? currentUser.PrescriptionsDoc : currentUser.PrescriptionsPat;
            }

            var prescriptions = _mapper.Map<IEnumerable<PrescriptionViewModel>>(userPrescriptions);
            prescriptions = prescriptions.OrderByDescending(a => a.CreateDate);

            return View(prescriptions);
        }

        [HttpGet]
        [Authorize(Roles = "Pharmacist")]
        public async Task<IActionResult> Realize(long prescriptionId)
        {
            var prescription = await _unitOfWork.Prescriptions.GetById(prescriptionId);

            var prescriptionVM = _mapper.Map<PrescriptionViewModel>(prescription);
            return View(prescriptionVM);
        }

        [HttpPost]
        [Authorize(Roles = "Pharmacist")]
        public async Task<IActionResult> RealizePost(long prescriptionId)
        {
            var prescription = await _unitOfWork.Prescriptions.GetById(prescriptionId);

            prescription.IsCollected = true;
            prescription.CollectedDate = DateTime.Now;

            if (await _unitOfWork.SaveChangesAsync() < 1)
            {
                ModelState.AddModelError("", "Error while saving realization");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
