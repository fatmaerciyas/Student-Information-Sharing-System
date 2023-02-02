using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogWriterRelationShip(); // writer-blog iliskisi
        List<Blog> GetBlogsByWriter(int id); // yazara ait bloglarin getirilmesi

        int CountBlogs();
        int CountBlogsByWriter(int id);

    }
}
