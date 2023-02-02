using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.ViewComponents.GetPopularBlogsHomePage
{
    public class GetPopularBlogsHomePage : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //var popularBlogs = cm
            var blogs = bm.GetBlogListWithComment().OrderByDescending(x => x.Comments.Count).Take(4).ToList();
            //.OrderBy(x => x.Comments.Count);

            return View(blogs);
        }
    }
}
