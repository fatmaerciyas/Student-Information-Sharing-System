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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult GetAllComments()
        {
            var comments = cm.GetListAllRelations();
            return View(comments);
        }
        public IActionResult AddComment()
        {
            return View();
        }
        public IActionResult DeleteComment(int id)
        {
            var comment = cm.GetByID(id);
            cm.TDelete(comment);
   
           
            return RedirectToAction("GetAllComments");
        }

    }
}
