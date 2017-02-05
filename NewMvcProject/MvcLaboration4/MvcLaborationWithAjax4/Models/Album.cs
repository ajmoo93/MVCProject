using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcLaborationWithAjax4.Models
{
    public class Album
    {
        public Guid AlbumID { get; set; }
        [Required(ErrorMessage = "Please enter a name for the Album")]
        public string AlbumName { get; set; }
        public ICollection<Comments> AlbumComments { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}