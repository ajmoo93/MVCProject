using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Laboration.Models
{
    public class AlbumModel
    {
        [Key]
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }

        public virtual ICollection<CommentModel> Comment { get; set; }
        public virtual ICollection<PhotoModel> Photo { get; set; }
    }
}