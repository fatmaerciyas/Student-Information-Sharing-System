using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace OgrenciBilgiPaylasimSistemi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult GetAllBlogs()
        {
            int page = 1;
            var blogs = bm.GetBlogWriterRelationShip().OrderByDescending(x => x.BlogCreateDate).ToPagedList(page, 70);
            return View(blogs);

        }

        public IActionResult DeleteBlogs(int id)
        {
            var blog = bm.GetByID(id);
            bm.TDelete(blog);
            return RedirectToAction("GetAllBlogs", "Blog");
        }
    }
}