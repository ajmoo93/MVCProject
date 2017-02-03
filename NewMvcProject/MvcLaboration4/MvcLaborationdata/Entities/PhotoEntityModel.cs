using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcLaborationdata.Entities
{
    public class PhotoEntityModel
    {
        public PhotoEntityModel()
        {
            Comment = new HashSet<CommentEntityModel>();
        }
        [Key]
        public Guid PhotoId { get; set; }

        public string PhotoName { get; set; }
        public virtual ICollection<CommentEntityModel> Comment { get; set; }
    }
}
