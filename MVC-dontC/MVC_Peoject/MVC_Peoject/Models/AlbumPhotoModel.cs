using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Peoject.Models
{
    public class AlbumPhotoModel
    {
        public virtual ICollection<PhotoModel> PhotoM { get; set; }
        public virtual ICollection<AlbumModel> AlbumM { get; set; }
    }
}