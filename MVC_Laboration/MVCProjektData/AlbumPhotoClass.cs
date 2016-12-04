using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData
{
   public class AlbumPhotoClass
    {
        [Key]
        public Guid Id { get; set; }
        public virtual ICollection<PhotoClass> PhotoMod { get; set; }
        public virtual ICollection<AlbumClass> AlbumMod { get; set; }
    }
}
