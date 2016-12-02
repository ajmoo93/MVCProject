using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Peoject.Models
{
    public class AlbumModel
    {
        public Guid AlbumID { get; set; }
        public string AlbumName { get; set; }
        public virtual ICollection<CommentModel> Comment { get; set; }
        public virtual ICollection<PhotoModel> Image { get; set; }
    }
}