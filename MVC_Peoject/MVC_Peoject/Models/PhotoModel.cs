using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Peoject.Models
{
    public class PhotoModel
    {
        public Guid PhotoID { get; set; }
        public string ImgName { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<string> Image { get; set; }
        public virtual ICollection<CommentModel> Comment { get; set; }
    }
}