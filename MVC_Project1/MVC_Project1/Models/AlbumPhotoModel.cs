using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Project1.Models
{
    public class AlbumPhotoModel
    {
        [Key]
        public Guid id { get; set; }
        public virtual ICollection<PhotoModel> PhotoMod { get; set; }
        public virtual ICollection<AlbumModel> AlbumMod { get; set; }
    }
}