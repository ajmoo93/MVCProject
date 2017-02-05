using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLaborationdata.Repository;
using MvcLaborationdata.Entities;
using MvcLaborationWithAjax4.Models;

namespace MvcLaborationWithAjax4.Mapping
{
    public class AlbumPhotoModelMapping
    {
        public static ICollection<Photo> MapPhotoModel(ICollection<PhotoEntityModel> photo)
        {
            var res = new List<Photo>();
            photo.ToList().ForEach(x => res.Add(MapPhotoModel(x)));
            return res;
        }

        public static Photo MapPhotoModel(PhotoEntityModel photo)
        {
            return new Photo
            {
                PhotoID = photo.PhotoId,
                PhotoName = photo.PhotoName,
                PhotoComment = PhotoModelMapping.MapCommentModel(photo.Comment),
            };
        }
        public static ICollection<PhotoEntityModel> MapPhotoEntityModel(ICollection<Photo> comments)
        {
            var res = new List<PhotoEntityModel>();
            comments.ToList().ForEach(x => res.Add(MapPhotoEntityModel(x)));
            return res;
        }

        public static PhotoEntityModel MapPhotoEntityModel(Photo photo)
        {
            return new PhotoEntityModel
            {
                PhotoId = photo.PhotoID,
                PhotoName = photo.PhotoName,
                Comment = PhotoModelMapping.MapCommentEntityModel(photo.PhotoComment)
            };
        }
        public static ICollection<Album> MapAlbumModel(ICollection<AlbumEntityModel> album)
        {
            var res = new List<Album>();
            album.ToList().ForEach(x => res.Add(MapAlbumModel(x)));
            return res;
        }

        public static Album MapAlbumModel(AlbumEntityModel album)
        {
            return new Album
            {
                AlbumID = album.AlbumId,
                AlbumName = album.AlbumName,
                AlbumComments = album.Comment.Select(x => CommentModelMapping.ModelToEntity(x)).ToList()
            };
        }
        public static ICollection<AlbumEntityModel> MapAlbumEntityModel(ICollection<Album> comments)
        {
            var res = new List<AlbumEntityModel>();
            comments.ToList().ForEach(x => res.Add(MapAlbumEntityModel(x)));
            return res;
        }

        public static AlbumEntityModel MapAlbumEntityModel(Album album)
        {
            return new AlbumEntityModel
            {
                AlbumId = album.AlbumID,
                AlbumName = album.AlbumName,
               Comment = album.AlbumComments.Select(x => CommentModelMapping.EntityToModel(x)).ToList(),
               Photo = album.Photos.Select(x => PhotoModelMapping.EntityToModel(x)).ToList()
            };
        }
    }
}