using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.ViewComponents.GetPopularWriters
{
    public class GetPopularWriters : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {

            var blogs = bm.GetBlogListWithComment().OrderByDescending(x => x.Comments.Count).Take(5).ToList();
            //var popularWriters = wm.
            return View(blogs);
        }
    }
}
