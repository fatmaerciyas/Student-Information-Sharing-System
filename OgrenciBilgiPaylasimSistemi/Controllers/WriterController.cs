using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiPaylasimSistemi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Controllers
{

    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

       
        public IActionResult Index()
        {
            var writers = wm.GetList();
            return View(writers);
        }

        public IActionResult WriterProfile(int id)
        {
            var writer = wm.GetByID(id);
            ViewBag.writerID = id;
            return View(writer);
        }
        
 
        [HttpGet]
        public IActionResult EditWriter()
        {
            var writerID = GetWriterID();
            var writerValues = wm.GetByID(writerID);
            return View(writerValues);
        }

        [HttpPost]
        public IActionResult EditWriter(Writer p)
        {

            wm.TUpdate(p);
            return RedirectToAction("EditWriter", "Writer");
        }

      
        public int GetWriterID()
        {
            var mail = User.Identity.Name;
            var writer = wm.WriterMailControl(mail);
            return writer.WriterID;
        }
    }
}
