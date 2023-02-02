using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OgrenciBilgiPaylasimSistemi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using X.PagedList;


namespace OgrenciBilgiPaylasimSistemi.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            int page = 1;
            var blogs = bm.GetBlogWriterRelationShip().OrderByDescending(x => x.BlogCreateDate).ToPagedList(page, 70);
            return View(blogs);
        }

        public IActionResult BlogDetails(int id)
        {

            var blog = bm.GetBlogByWriter(id);
            //blog.BlogContent = WebUtility.HtmlDecode(blog.BlogContent);

            ViewBag.countComments = cm.GetListByBlog(id).Count();

            ViewBag.id = id;
            return View(blog);
        }


        [HttpGet]
        public ActionResult AddBlog()
        {
            List<SelectListItem> categoryvalues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(NewBlog p)
        {


            Blog b = new Blog();
            Writer w = new Writer();

            if (p.BlogThumbnailImage != null)
            {
                var extension = Path.GetExtension(p.BlogThumbnailImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BlogThumbnails/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.BlogThumbnailImage.CopyTo(stream);
                b.BlogThumbnailImage = newImageName;
            }

            p.WriterID = GetWriterID();
            b.BlogID = p.BlogID;
            b.BlogTitle = p.BlogTitle;
            b.BlogContent = p.BlogContent;
            b.BlogCreateDate = DateTime.Now;
            b.BlogStatus = true;
            b.Category = p.Category;
            b.CategoryID = p.CategoryID;
            var writerID = GetWriterID();
            var writer = wm.GetByID(writerID);
            w = writer;
            b.WriterID = p.WriterID;
            b.BlogCreateDate = DateTime.Now;
            b.Comments = p.Comments;
            if (w.WriterStatus == false)
            {
                return RedirectToAction("Ban");
            }
            else
            {
                bm.TAdd(b);

                return RedirectToAction("Index", "Blog");
            }

        }

        public IActionResult Ban()
        { return View(); }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryvalues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;

            var blog = bm.GetBlogByID(id);

            if (blog.BlogThumbnailImage != null)
            {
                ViewBag.ThumbnailImage = blog.BlogThumbnailImage;
            }
            else
            {
                ViewBag.ThumbnailImage = "Kapak görseli bulunmamakta";
            }

            return View(blog);
        }

        [HttpPost]
        public IActionResult EditBlog(NewBlog model )
        {
            Blog b = new Blog();
           
            if (model.BlogThumbnailImage != null)
            {
                var extension = Path.GetExtension(model.BlogThumbnailImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BlogThumbnails/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                model.BlogThumbnailImage.CopyTo(stream);
                b.BlogThumbnailImage = newImageName;
            }

           
            model.WriterID = GetWriterID();
            b.BlogID = model.BlogID;
            b.BlogTitle = model.BlogTitle;
            b.BlogContent = model.BlogContent;
            b.BlogCreateDate = DateTime.Now;
            b.BlogStatus = true;
            b.Category = model.Category;
            b.CategoryID = model.CategoryID;
           
            b.WriterID = model.WriterID;
            b.BlogCreateDate = DateTime.Now;
            b.Comments = model.Comments;

          
            bm.TUpdate(b);
            return RedirectToAction("BlogsByWriter", "Blog");
        }

        public IActionResult DeleteBlog(int id)
        {
            var blog = bm.GetByID(id);
            //burada BlogThumbnailImage in da wwwroot'un altindaki klasorden silinmesi gerek
            bm.TDelete(blog);
            return RedirectToAction("BlogsByWriter");
        }

        public IActionResult BlogsByWriter()
        {
            int writerID = GetWriterID();
            var blogs = bm.GetBlogsByWriter(writerID);
            return View(blogs);
        }

        [AllowAnonymous]
        public IActionResult GetBlogsBySearch(string search)
        {
            var blogs = bm.GetBlogsBySearch(search);
            ViewBag.blogCount = blogs.Count();
            return View(blogs);
        }

        public PartialViewResult PartialGetBlogsBySearch()
        {
            return PartialView();
        }

        public int GetWriterID()
        {
            var mail = User.Identity.Name;
            var writer = wm.WriterMailControl(mail);
            return writer.WriterID;
        }
    }
}
