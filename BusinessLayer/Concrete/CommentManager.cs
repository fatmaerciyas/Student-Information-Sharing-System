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
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }


        public Comment GetByID(int id)
        {
            return commentDal.GetByID(id);
        }

        public List<Comment> GetListByBlog(int id)
        {
            return commentDal.GetListAll(x => x.BlogID == id && x.CommentStatus == true);
        }
        public List<Comment> GetRelationsAndCommentsByBlogDetails(int id)
        {
            return commentDal.GetRelationsAndCommentsByBlogDetails(id);
        }

        public List<Comment> GetLastCommentsByWriter(int id)
        {
            return commentDal.GetListAll().Where(x=>x.WriterID == id).TakeLast(7).ToList(); // Son 7 yorumu getir getir
        }

        public List<Comment> GetCommentsByWriter(int id)
        {
            return commentDal.GetListAll().Where(x => x.WriterID == id ).ToList();
        }

        public List<Comment> GetList()
        {
            return commentDal.GetListAll();
        }

        public List<Comment> GetListAllRelations()
        {
            return commentDal.GetCommentWithRelationShip();
        }

        public void TAdd(Comment t)
        {
            commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            t.CommentStatus = false;
          
            commentDal.Delete(t);
        }

        
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
