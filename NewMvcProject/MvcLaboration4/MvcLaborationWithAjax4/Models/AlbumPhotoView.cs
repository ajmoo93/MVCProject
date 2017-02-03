using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLaborationWithAjax4.Models
{
    public class AlbumPhotoView
    {
        public Guid Id { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}