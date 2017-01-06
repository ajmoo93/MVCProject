using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace MVC_Laboration.Models
{
    public class PhotoModel
    {
        [Key]
        public Guid PhotoId { get; set; }
        public string PhotoName { get; set; }
        public DateTime Date { get; set; }

        public  ICollection<PhotoModel> Photo { get; set; }
        public  ICollection<CommentModel> PComment { get; set; }
    }
}