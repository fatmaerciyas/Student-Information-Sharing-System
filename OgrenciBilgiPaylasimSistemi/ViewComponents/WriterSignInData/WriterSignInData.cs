using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.ViewComponents.WriterSignInData
{
    public class WriterSignInData : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var writerID = GetWriterID();
            var writer = wm.GetByID(writerID);
            return View(writer);
        }


        public int GetWriterID()
        {
            var mail = User.Identity.Name;
            var writer = wm.WriterMailControl(mail);
            return writer.WriterID;
        }
    }
}
