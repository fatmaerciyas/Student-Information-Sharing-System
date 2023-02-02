using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetBlogWriterRelationShip()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Writer).ToList();
            }
        }
        public Blog GetBlogByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Writer).Where(y => y.BlogID == id).FirstOrDefault();
            }
        }

        public int GetCountBlogWithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Where(x => x.WriterID == id).Count();
            }
            
        }

        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetListWithWriter()
        {
            using (var c = new Context())
            {
                var blogs =  c.Blogs.Include(x => x.Writer).ToList();
                return blogs.TakeLast(7).ToList();
            }            
        }

        public List<Blog> GetListWithComment()
        {
            using (var c = new Context())
            {
                return c.Blogs
                    .Include(x => x.Comments)
                    .Include(y => y.Category)
                    .Include(z => z.Writer)
                    .ToList();
            }
        }


        //public List<Blog> GetListWithCategoryByWriter(int id)
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Blogs.Include(x => x.Category).Where(x => x.WriterID == id).ToList();
        //    }
        //}
    }
}
