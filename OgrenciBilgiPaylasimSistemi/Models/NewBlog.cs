using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OgrenciBilgiPaylasimSistemi.Models
{
    public class NewBlog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        [NotMapped]
        [DisplayName("Dosya Seçiniz")]
        public IFormFile BlogThumbnailImage { get; set; }
        [NotMapped]
        [DisplayName("Dosya Seçiniz")]
        public List<IFormFile> BlogImages { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        //Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //Comment
        public List<Comment> Comments { get; set; }
        ////Writer
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
    }
}
