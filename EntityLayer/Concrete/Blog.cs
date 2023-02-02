using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        //Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //Comment
        public List<Comment> Comments { get; set; }
       //Writer
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
      
      
    }
}
