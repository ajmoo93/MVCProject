using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Database.Models
{
    public class AlbumClass
    {
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }
        public Guid CommentId { get; set; }
        public Guid PhotoId { get; set; }
        public virtual ICollection<CommentClass> Comment { get; set; }
        public virtual ICollection<PhotoClass> Photo { get; set; }
    }
}