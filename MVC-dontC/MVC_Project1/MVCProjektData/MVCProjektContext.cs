using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;




namespace MVCProjektData
{
   public class MVCProjektContext : DbContext
    {
        public MVCProjektContext() : base("name=GalleryContext")
        {

        }
         
        public DbSet<PhotoClass> photo { get; set; }
        public DbSet<AlbumClass> album { get; set; }
        public DbSet<AccountClass> account { get; set; }
        public DbSet<AlbumPhotoClass> albumPhoto { get; set; }
        public DbSet<CommentClass> comment { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //}
    }
}
