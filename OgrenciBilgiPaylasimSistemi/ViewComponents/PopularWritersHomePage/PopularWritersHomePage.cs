using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.ViewComponents.PopularWritersHomePage
{
    public class PopularWritersHomePage : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {

            var blogs = bm.GetBlogListWithComment().Distinct().OrderByDescending(x => x.Comments.Count).Take(4).ToList();
            return View(blogs);
        }
    }
}
