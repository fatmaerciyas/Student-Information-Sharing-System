using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Models
{
    public class WriterViewModel
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        [NotMapped]
        [DisplayName("Yazar Profil Fotoğrafı Seçiniz")]
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
        //Blog
        public List<Blog> Blogs { get; set; }

        //Comments
        public List<Comment> Comments { get; set; }
    }
}
