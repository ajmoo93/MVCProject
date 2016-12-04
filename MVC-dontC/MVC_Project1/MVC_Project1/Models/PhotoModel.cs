using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVC_Project1.Models
{
    public class PhotoModel
    {
        [Key]
        public Guid PhotoId { get; set; }
        public string PhotoName { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<string> Photos { get; set; }
        public virtual ICollection<CommentModel>Comment { get; set; }
    }
}