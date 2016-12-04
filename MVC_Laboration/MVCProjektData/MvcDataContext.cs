using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MVCProjektData
{
   public class MvcDataContext : DbContext
    {
        public MvcDataContext() : base("name=GalleryContext")
        {

        }

        public DbSet<PhotoClass> photo { get; set; }
        public DbSet<AlbumClass> album { get; set; }
        public DbSet<AccountClass> account { get; set; }
        public DbSet<AlbumPhotoClass> albumPhoto { get; set; }
        public DbSet<CommentClass> comment { get; set; }

       
    }
}
