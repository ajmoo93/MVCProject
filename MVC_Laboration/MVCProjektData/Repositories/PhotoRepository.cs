using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData.Repositories
{
        public class PhotoRepository
        {
            public List<PhotoClass> GetAllPhoto()
            {
                using (var context = new MvcDataContext())
                {
                    var photos = context.photo.Include("Comment").ToList();
                    return photos;
                }

            }
            public void AddPhoto(PhotoClass newphoto)
            {
                using (var context = new MvcDataContext())
                {
                    PhotoClass photo = new PhotoClass();
                    photo.PhotoId = newphoto.PhotoId;
                    photo.PhotoName = newphoto.PhotoName;
                    photo.PComment = newphoto.PComment;
                    context.photo.Add(photo);
                    context.photo.AddOrUpdate(photo);
                    context.SaveChanges();
                }
            }
            public void DeletePhoto(PhotoClass photo)
            {
                using (var context = new MvcDataContext())
                {
                    var photoToDelete = context.photo.Include("Comment").FirstOrDefault(p => p.PhotoId == photo.PhotoId);
                    context.photo.Remove(photoToDelete);
                    context.photo.AddOrUpdate(photoToDelete);
                    context.SaveChanges();
                }
            }

            public PhotoClass GetPhoto(Guid id)
            {
                using (var context = new MvcDataContext())
                {
                    return context.photo.Include("Comment").FirstOrDefault(p => p.PhotoId == id);
                }
            }
            public PhotoClass AddCommentToPhoto(Guid id, string photoComment)
            {
                using (var context = new MvcDataContext())
                {
                    var phototocomment = context.photo.Include("Comment").FirstOrDefault(x => x.PhotoId == id);
                    phototocomment.PComment.Add(new CommentClass { Id = Guid.NewGuid(), CommentOnPhoto = photoComment });
                    context.photo.AddOrUpdate(phototocomment);
                    context.SaveChanges();
                    return phototocomment;
                }
            }
        }
    }