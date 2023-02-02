using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OgrenciBilgiPaylasimSistemi.Models;
using OgrenciBilgiPaylasimSistemi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Controllers
{

    [AllowAnonymous]
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index(RegisterViewModel p)
        {

            Writer writer = new Writer();
            writer.WriterMail = p.Mail;
            writer.WriterPassword = p.Password;
            writer.WriterName = p.NameSurname;
            writer.WriterStatus = true;

            wm.TAdd(writer);
            return RedirectToAction("Index","Blog");
        }

        public IActionResult Error()
        { return View(); }


        //public string AktivasyonKoduGonder(string uyeMail)
        //{
        //    string mail = "fatmaerciyas22@gmail.com";
        //    string sifre = "17366875104";

        //    Random rnd = new Random();
        //    string karakter = "ABCDEFGHIJKLMNOPRSTUVYZWX0123456789";
        //    var kod = "";
        //    for (int i = 0; i < 6; i++)
        //    {
        //        kod += karakter[rnd.Next(karakter.Length)];
        //    }
        //    try
        //    {
        //        string yol = "https://localhost:44397/Blog/Index?Kod=" + kod;
        //        MailMessage mesaj = new MailMessage(mail, uyeMail, "Onay Kodu", "Üyeliğinizin onaylanması için bu adresten aktivasyon işleminizi yapabilirsiniz\n\n" + yol);
        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //        smtp.Credentials = new NetworkCredential(mail, sifre);
        //        smtp.EnableSsl = true;

        //        smtp.Send(mesaj);
        //        return kod;
        //    }
        //    catch (Exception ex)
        //    {
        //        new Exception("Onay Kodu Gönderiminde Hata" + ex.Message);
        //    }
        //    return kod;
        //}




        //{
        //    WriterManager wm = new WriterManager(new EfWriterRepository());

        //    [HttpGet]
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    public IActionResult Index(Writer p)
        //    {
        //        p.WriterStatus = true;
        //        p.WriterAbout = "Deneme";
        //        wm.TAdd(p);
        //        return RedirectToAction("Index","Blog"); // Burada Dashboard'a yönlendirilecek
        //    }

        //if(ModelState.IsValid)
        //{
        //    AppUser user = new AppUser()
        //    {
        //        Email = p.Mail,
        //        NameSurname = p.NameSurname,
        //        UserName = p.UserName
        //    };

        //    var results = await userManager.CreateAsync(user, p.Password);
        //    if (results.Succeeded)
        //    {


        //        return RedirectToAction("Index", "Blog");

        //    }

        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError("", item.Description);
        //        }
        //    }
        //}

    }
}


//var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
//var confirmationLink = Url.Action("ConfirmEmail", "Email", new { userId = user.Id, token = token }, Request.Scheme);

//EmailHelper emailHelper = new EmailHelper();
//bool emailResponse = emailHelper.SendEmail(user.Email, confirmationLink);
