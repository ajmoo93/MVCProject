using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVC_Project1.Models
{
    public class CommentModel
    {
        [Key]
        public Guid id { get; set; }
        public string CommentPhoto { get; set; }
        public string CommentAlbum { get; set; }

    }
}