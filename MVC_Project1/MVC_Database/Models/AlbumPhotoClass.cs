using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Database.Models
{
    public class AlbumPhotoClass
    {
        public virtual ICollection<PhotoClass> PhotoMod { get; set; }
        public virtual ICollection<AlbumClass> AlbumMod { get; set; }
    }
}