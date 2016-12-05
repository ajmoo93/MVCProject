using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Laboration.Models
{
    public class AlbumPhoto
    {
        [Key]
        public Guid Id { get; set; }
        public IEnumerable<PhotoModel> PhotoMod { get; set; }
        public IEnumerable<AlbumModel> AlbumMod { get; set; }
    }
}