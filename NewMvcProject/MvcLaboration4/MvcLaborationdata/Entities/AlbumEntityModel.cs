using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcLaborationdata.Entities
{
    public class AlbumEntityModel
    {
        public AlbumEntityModel()
        {
            Comment = new HashSet<CommentEntityModel>();
            Photo = new HashSet<PhotoEntityModel>();
        }

        [Key]
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }
        public virtual ICollection<CommentEntityModel> Comment { get; set; }
        public virtual ICollection<PhotoEntityModel> Photo { get; set; }
    }
}
