using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    public class AlbumModel
    {
        
        public string AlbumName { get; set; }
        public List<AlbumModel> album { get; set; }

    }
}