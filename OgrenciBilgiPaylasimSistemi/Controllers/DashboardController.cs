using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Controllers
{
    public class DashboardController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var writerID = GetWriterID();
            var writervalue = wm.GetByID(writerID);
            ViewBag.writerBlogCount = bm.CountBlogsByWriter(writerID);
            ViewBag.writerCommentCount = cm.GetCommentsByWriter(writerID).Count();
            ViewBag.totalWriter = wm.GetList().Count();
            ViewBag.totalBlog = bm.GetList().Count();
            return View(writervalue);
            
        }

        public int GetWriterID()
        {
            var mail = User.Identity.Name;
            var writer = wm.WriterMailControl(mail);
            return writer.WriterID;
        }
    }
}
