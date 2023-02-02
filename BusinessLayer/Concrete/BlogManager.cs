using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }
     
        
        public List<Blog> GetBlogListWithComment()
        {
            return blogDal.GetListWithComment();
        }

        public List<Blog> GetLast7Blog()
        {
            return blogDal.GetListWithWriter(); // Son 7 postu getir
        }

        public Blog GetByID(int id)
        {
            return blogDal.GetByID(id);
        }

        //public List<Blog> GetListWithCategoryByWriterBm(int id)
        //{
        //    return blogDal.GetListWithCategoryByWriter(id);
        //}

        public Blog GetBlogByID(int id)
        {
            return blogDal.Get(x => x.BlogID == id);
        }


        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }

        public List<Blog> GetBlogsBySearch(string search)
        {
            return blogDal.GetListAll(x => x.BlogTitle.Contains(search));
        }

        public List<Blog> GetBlogWriterRelationShip()
        {
            return blogDal.GetBlogWriterRelationShip();
        }

        public Blog GetBlogByWriter(int id) //bloga ait yazari getirmek
        {
            return blogDal.GetBlogByWriter(id);
        }

        public void TAdd(Blog t)
        {
            blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            blogDal.Delete(t);
            
        }

        public void TUpdate(Blog t)
        {
            blogDal.Update(t);
        }

        public int CountBlogs()
        {
            return blogDal.GetListAll().Count();
        }

        public int CountBlogsByWriter(int id)
        {
            return blogDal.GetCountBlogWithWriter(id);
        }

        public List<Blog> GetBlogsByWriter(int id) //yazara ait bloglari getirmek
        {
            return blogDal.GetListAll(x => x.WriterID == id);
        }
    }
}
