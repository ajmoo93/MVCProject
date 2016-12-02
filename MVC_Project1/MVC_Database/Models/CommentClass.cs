using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Database.Models
{
    public class CommentClass
    {
        public Guid CommentId { get; set; }
        public string CommentPhoto { get; set; }
        public string CommentAlbum { get; set; }

    }
}