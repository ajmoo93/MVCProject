using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcLaborationdata.Repository;
using MvcLaborationdata.Entities;

namespace MvcLaborationdata
{
    class MvcDataContext : DbContext
    {
        public DbSet<AlbumEntityModel> AlbumEntityModels { get; set; }
        public DbSet<CommentEntityModel> CommentEntityModels { get; set; }
        public DbSet<PhotoAlbumEntityModel> PhotoAlbumEntityModels { get; set; }
        public DbSet<PhotoEntityModel> PhotoEntityModels { get; set; }
    }
}
