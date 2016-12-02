using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDatabase.Models
{
    public class PhotoCLass
    {
        [Key]
        public Guid PhotoID {get; set;}
        public string ImgName { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<string> Image { get; set; }
        public virtual ICollection<CommentCLass> Comment { get; set; }
        
    }
}