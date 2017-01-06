using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData.Repositories
{
    public class AlbumRepository
    {
        public List<AlbumClass> GetAllAlbums()
        {

            using (var context = new MvcDataContext())
            {

                var albums = context.album.Include("Comment").Include("Photo").ToList();
                return albums;
            }

        }
        public void AddNewAlbum(AlbumClass newalbum)
        {
            using (var context = new MvcDataContext())
            {
                AlbumClass album = new AlbumClass();
                album.AlbumId = newalbum.AlbumId;
                album.AlbumName = newalbum.AlbumName;
                album.Comment = newalbum.Comment;
                //album.Photo = newalbum.Photo;
                context.album.Add(album);
                context.album.AddOrUpdate(album);
                context.SaveChanges();
            }
        }
        public AlbumClass ShowAlbum(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                return context.album.Include("Comment").FirstOrDefault(x => x.AlbumId == id);

            }

        }
        public AlbumClass AddCommentToAlbum(Guid id, string albumComment)
        {
            using (var context = new MvcDataContext())
            {
                var albumtocomment = context.album.Include("Comment").FirstOrDefault(x => x.AlbumId == id);
                albumtocomment.Comment.Add(new CommentClass { Id = Guid.NewGuid(), CommentOnAlbum = albumComment });
                context.album.AddOrUpdate(albumtocomment);
                context.SaveChanges();
                return albumtocomment;
            }
        }
        public void AddPhotoToAlbum(IEnumerable<Guid> photos, Guid albumID)
        {
            using (var context = new MvcDataContext())
            {
                var albumToAddIn = context.album.FirstOrDefault(x => x.AlbumId == albumID);
                foreach (var item in photos)
                {
                    albumToAddIn.Photo.Add(context.photo.Include("Comment").FirstOrDefault(x => x.PhotoId == item));
                }
                context.album.AddOrUpdate(albumToAddIn);
                context.SaveChanges();
            }
        }
    }
}
