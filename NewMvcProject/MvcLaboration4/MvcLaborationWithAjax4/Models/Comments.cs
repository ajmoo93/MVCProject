using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLaborationWithAjax4.Models
{
    public class Comments
    {
        public Guid Id { get; set; }
        public string CommentOnPicture { get; set; }
        public string CommentOnAlbum { get; set; }
    }
}