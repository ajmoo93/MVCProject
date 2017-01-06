using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData
{
    public class PhotoClass
    {
        public PhotoClass()
        {
            PComment = new HashSet<CommentClass>();
        }
        [Key]
        public Guid PhotoId { get; set; }
        public string PhotoName { get; set; }
        public DateTime Date { get; set; }

        public  ICollection<PhotoClass> Photo { get; set; }
        public  ICollection<CommentClass> PComment { get; set; }
    }
}
