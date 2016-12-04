using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProjektData
{
    class AlbumPhotoClass
    {
        public virtual ICollection<PhotoClass> PhotoM { get; set; }
        public virtual ICollection<AlbumClass> AlbumM { get; set; }
    }
}
