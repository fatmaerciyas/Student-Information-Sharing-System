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
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
  

        public List<Comment> GetCommentWithRelationShip()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Blog)
                    .Include(x => x.Writer).ToList();
            
            }
        }

        public List<Comment> GetRelationsAndCommentsByBlogDetails(int id)
        {
            List<Comment> comList = new List<Comment>();
            using (var c = new Context())
            {
                c.Comments.Include(x => x.Blog)
                    .Include(x => x.Writer).ToList();

                foreach (var item in c.Comments.Include(x => x.Blog)
                    .Include(x => x.Writer).ToList())
                {
                    if(item.BlogID == id)
                    {
                        comList.Add(item);
                    }
                }
                return comList;
            }
        }

        
    }
}
