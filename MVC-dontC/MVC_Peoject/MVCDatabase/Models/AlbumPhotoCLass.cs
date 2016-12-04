using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDatabase.Models
{
    public class AlbumPhotoCLass
    {
        [Key]
        public Guid id { get; set; }
        public virtual ICollection<PhotoCLass> photoMod { get; set; }
        public virtual ICollection<AlbumClass> albumMod { get; set; }
        
        
    }
}