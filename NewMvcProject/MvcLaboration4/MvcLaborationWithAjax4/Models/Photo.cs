using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLaborationWithAjax4.Models
{
    public class Photo
    {
        public Guid PhotoID { get; set; }
        public string PhotoName { get; set; }
        public ICollection<Comments> PhotoComment { get; set; }
    }
}