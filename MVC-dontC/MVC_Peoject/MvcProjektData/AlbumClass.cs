using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProjektData
{
    class AlbumClass
    {
        public Guid AlbumID { get; set; }
        public string AlbumName { get; set; }
        public virtual ICollection<CommentClass> Comment { get; set; }
        public virtual ICollection<PhotoClass> Image { get; set; }
    }
}
