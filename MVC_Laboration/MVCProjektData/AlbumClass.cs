using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData
{
    public class AlbumClass
    {
        [Key]
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }

        public virtual ICollection<CommentClass> Comment { get; set; }
        public virtual ICollection<PhotoClass> Photo { get; set; }
    }
}
