using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Database.Models
{
    public class PhotoClass
    {
        public Guid PhotoId { get; set; }
        public string PhotoName { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<string> Photos { get; set; }
        public virtual ICollection<CommentClass> Comment { get; set; }
    }
}