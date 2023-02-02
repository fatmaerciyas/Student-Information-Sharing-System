using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }
        //Blog
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        
        //Writer
        public int? WriterID { get; set; }
        public Writer Writer { get; set; }
    }
}
