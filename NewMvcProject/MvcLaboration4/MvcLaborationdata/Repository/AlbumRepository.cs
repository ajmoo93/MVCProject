using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcLaborationdata.Entities;

namespace MvcLaborationdata.Repository
{
   public class AlbumRepository
    {
        public List<AlbumEntityModel> GetAlbum()
        {
            using (var context = new MvcDataContext())
            {
                var albums = context.AlbumEntityModels.Include("Comments").ToList();
                return albums;
            }
        }

        public void AddAlbum(AlbumEntityModel newalbum)
        {
            using (var context = new MvcDataContext())
            {
                AlbumEntityModel album = new AlbumEntityModel();
                album.AlbumId = newalbum.AlbumId;
                album.AlbumName = newalbum.AlbumName;
                album.Comment = newalbum.Comment;
                context.AlbumEntityModels.Add(album);
                context.AlbumEntityModels.AddOrUpdate(album);
                context.SaveChanges();
            }

        }

        public void DeleteAlbum(AlbumEntityModel album)
        {
            using (var context = new MvcDataContext())
            {
                var deleteAlbum =
                    context.AlbumEntityModels.Include("Comment").FirstOrDefault(x => x.AlbumId == album.AlbumId);
                context.AlbumEntityModels.Remove(deleteAlbum);
                context.AlbumEntityModels.AddOrUpdate(deleteAlbum);
                context.SaveChanges();
            }
        }

        public AlbumEntityModel GetPhoto(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                return context.AlbumEntityModels.Include("Comment").FirstOrDefault(x => x.AlbumId == id);

            }
        }

        public AlbumEntityModel AddComment(Guid id, string albumComment)
        {
            using (var context = new MvcDataContext())
            {
                var albumcomment = context.AlbumEntityModels.Include("Comment").FirstOrDefault(x => x.AlbumId == id);
                albumcomment.Comment.Add(new CommentEntityModel {Id = Guid.NewGuid(), CommentAlbum = albumComment});
                context.AlbumEntityModels.AddOrUpdate(albumcomment);
                context.SaveChanges();
                return albumcomment;
            }
        }
    }
}
