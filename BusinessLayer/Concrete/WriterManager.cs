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
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return writerDal.GetByID(id);
        }

        public List<Writer> GetList()
        {
            return writerDal.GetListAll();
        }

        public void TAdd(Writer t)
        {
            t.WriterStatus = true;
            writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
         
            writerDal.Update(t);
        }

        public Writer WriterLoginControl(string Mail, string password)
        {
            return writerDal.Get(x => x.WriterMail == Mail && x.WriterPassword == password);
        }

        public Writer WriterMailControl(string Mail)
        {
            return writerDal.Get(x => x.WriterMail == Mail);
        }
    }
}
