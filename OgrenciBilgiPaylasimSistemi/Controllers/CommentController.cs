using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Controllers
{
    public class CommentController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }


        [HttpPost]
        public IActionResult AddComment(Comment p, int id) //BlogId
        {

            p.WriterID = GetWriterID();
            p.CommentStatus = true;
            p.CommentCreateDate = DateTime.Now;
            cm.TAdd(p);
            System.Threading.Thread.Sleep(1000);

            return RedirectToAction("BlogDetails", "Blog", new { id });
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = cm.GetByID(id);
            cm.TDelete(comment);
            id = 0;
            id = comment.BlogID;
            var blog = bm.GetBlogByID(id);
            return RedirectToAction("BlogDetails", "Blog", new { id });
        }


        public int GetWriterID()
        {
            var mail = User.Identity.Name;
            var writer = wm.WriterMailControl(mail);
            return writer.WriterID;
        }
    }
}
