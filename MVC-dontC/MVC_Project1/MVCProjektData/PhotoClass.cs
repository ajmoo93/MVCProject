using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData
{
   public  class PhotoClass
    {
        [Key]
        public Guid PhotoId { get; set; }
        public string PhotoName { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<string> Photo { get; set; }
        public virtual ICollection<CommentClass> Comment { get; set; }
    }
}
