//using ClinicManagement.Entities;
//using ClinicManagement.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ClinicManagement.Controllers
//{
//    [Authorize]
//    public class AccountController : Controller
//    {
//        private readonly UserManager<User> _userManager;
//        private readonly SignInManager<User> _signInManager;
//        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        [AllowAnonymous]
//        public IActionResult Login()
//        {
//            if (User.Identity.IsAuthenticated)
//                return RedirectToAction("Index", "Home");

//            return View();
//        }

//        [HttpPost]
//        [AllowAnonymous]
//        public async Task<IActionResult> Login(UserLoginViewModel user)
//        {
//            if (ModelState.IsValid)
//            {
//                var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, false, false);

//                if (result.Succeeded)
//                    return RedirectToAction("Index", "Home");

//                ModelState.AddModelError("LoginError", "Invalid login attempt");

//            }
//            return View(user);
//        }

//        [HttpGet]
//        public async Task<IActionResult> Logout()
//        {
//            await _signInManager.SignOutAsync();

//            return RedirectToAction("Login", "Account");
//        }
//    }
//}
