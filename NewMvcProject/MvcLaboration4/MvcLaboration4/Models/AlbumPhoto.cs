using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLaboration4.Models
{
    public class AlbumPhoto
    {
        public List<Photo> Photos { get; set; }
        public List<Album> Albums { get; set; }
    }
}