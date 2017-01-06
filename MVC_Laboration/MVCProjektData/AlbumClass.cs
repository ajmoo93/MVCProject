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
        public AlbumClass()
        {
            Comment = new HashSet<CommentClass>();
            Photo = new HashSet<PhotoClass>();
        }
        [Key]
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }

        public  ICollection<CommentClass> Comment { get; set; }
        public  ICollection<PhotoClass> Photo { get; set; }
    }
}
