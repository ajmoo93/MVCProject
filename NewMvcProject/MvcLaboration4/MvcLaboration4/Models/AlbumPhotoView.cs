using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLaboration4.Models
{
    public class AlbumPhotoView
    {
        public List<Photo> Photos { get; set; }
        public List<Album> Albums { get; set; }
    }
}