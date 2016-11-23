using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    public class AlbumModel
    {
        public Guid AlbumID { get; set; }
        public string AlbumName { get; set; }
        public List<Comment> albumCom { get; set; }
        public List<MyModel> pic { get; set; }

    }
}