using EntityLayer.Concrete;
using BC = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiPaylasimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Concrete;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace OgrenciBilgiPaylasimSistemi.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminLogin(Admin p)
        {

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.Mail && x.WriterPassword == p.Password); // Role gore giris de yapilabilir

            if (datavalue != null)
            {
                var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, p.Mail)
                            };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("GetAllBlogs", "Blog", new { area = "Admin" });
            }
            return View();
        }

            [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel p)
        {

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.Email && x.WriterPassword == p.Password); // Role gore giris de yapilabilir

            if (datavalue != null)
            {
                var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, p.Email)
                            };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }

            else
            {
                return RedirectToAction("Index", "Dashboard");
            }

        }


        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

    }
}


//--Identity ile Login islemi

//      [HttpPost]
//public async Task<IActionResult> Login(LoginViewModel model)
//{
//    if (ModelState.IsValid)
//    {

//        //var user = await userManager.FindByEmailAsync(model.Email);
//        //var password = await userManager.CheckPasswordAsync(user, model.Password);
//        //var passwordHashed = BC.HashPassword(model.Password);

//        var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

//        //var user = await signInManager.UserManager.FindByEmailAsync(model.Email);
//        //var userPrincipal = await signInManager.CreateUserPrincipalAsync(user);
//        //var identity = userPrincipal.Identity;

//        //var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

//        if (result.Succeeded) // Succeedded
//        {

//            return RedirectToAction("Index", "Blog");


//        }
//        ModelState.AddModelError("", "Mail veya Şifre doğru değil");
//    }

//    return View(model);
//}