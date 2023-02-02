using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.ViewComponents.Comment
{
    public class GetLastCommentsByWriter : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id) // comments by writerid
        {
            var comments = cm.GetLastCommentsByWriter(id);
            return View(comments);
          
        }
    }
}
