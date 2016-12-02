using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MVCDatabase.Models
{
    public class AlbumClass : DbSet
    {
       [Key]
        public Guid AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string PhotoID { get; set; }
        


        public virtual ICollection<CommentCLass> Comment { get; set; }
        public virtual ICollection<PhotoCLass> Image { get; set; }
    }
}