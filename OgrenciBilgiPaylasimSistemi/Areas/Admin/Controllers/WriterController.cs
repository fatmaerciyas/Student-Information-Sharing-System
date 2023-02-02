using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult GetAllWriters()
        {
            var writers = wm.GetList();
            return View(writers);
        }

        public IActionResult UpdateWriter(int id)
        {
            var writer = wm.GetByID(id);
            if(writer.WriterStatus == false) { writer.WriterStatus = true; }
            else { writer.WriterStatus = false; }

            wm.TUpdate(writer);
            return RedirectToAction("GetAllWriters", "Writer");
        }
    }
}
