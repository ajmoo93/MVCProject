using System;
using System.Collections.Generic;
using System.Linq;
using MVCProjektData.Repositories;
using MVC_Laboration.Models;
using MVCProjektData;
using System.Web;

namespace MVC_Laboration.Mapping
{
    public class AlbumModelMapping
    {
        public static AlbumClass EntityToModel(AlbumModel albumModel)
        {
            AlbumClass entity = new AlbumClass();
            entity.AlbumId = albumModel.AlbumId;
            entity.AlbumName = albumModel.AlbumName;
            entity.Comment = MapCommentsEntityModel(albumModel.AComment);
            return entity;
        }
        public static AlbumModel ModelToEntity(AlbumClass entityModel)
        {
            var model = new AlbumModel();
            model.AlbumId = entityModel.AlbumId;
            model.AlbumName = entityModel.AlbumName;
            
            model.AComment = MapCommentsModel(entityModel.Comment);
            return model;
        }
        public static ICollection<CommentClass> MapCommentsEntityModel(ICollection<CommentModel> comments)
        {
            var result = new List<CommentClass>();
            comments.ToList().ForEach(x => result.Add(MapCommentsEntityModel(x)));
            return result;
        }
        public static CommentClass MapCommentsEntityModel(CommentModel comments)
        {
            return new CommentClass
            {
                Id = comments.Id,
                CommentOnPhoto = comments.CommentPhoto,
                CommentOnAlbum = comments.CommentAlbum
            };
        }
        public static ICollection<CommentModel> MapCommentsModel(ICollection<CommentClass> comments)
        {
            var result = new List<CommentModel>();
            comments.ToList().ForEach(x => result.Add(MapCommentsModel(x)));
            return result;
        }
        public static CommentModel MapCommentsModel(CommentClass comments)
        {
            return new CommentModel
            {
                Id = comments.Id,
                CommentPhoto = comments.CommentOnPhoto,
                CommentAlbum = comments.CommentOnAlbum
            };
        }
        public static ICollection<PhotoModel> MapPhotoModel(ICollection<PhotoClass> photo)
        {
            var result = new List<PhotoModel>();
            photo.ToList().ForEach(x => result.Add(MapPhotoModel(x)));
            return result;
        }
        public static PhotoModel MapPhotoModel(PhotoClass photo)
        {
            return new PhotoModel
            {
                PhotoId = photo.PhotoId,
                PhotoName = photo.PhotoName,
                PComment = PhotoModelMapping.MapCommentsModel(photo.PComment),
                
            };
        }
        public static ICollection<PhotoClass> MapPhotoEntityModel(ICollection<PhotoModel> comments)
        {
            var result = new List<PhotoClass>();
            comments.ToList().ForEach(x => result.Add(MapPhotoEntityModel(x)));
            return result;
        }
        public static PhotoClass MapPhotoEntityModel(PhotoModel photo)
        {
            return new PhotoClass
            {
                PhotoId = photo.PhotoId,
                PhotoName = photo.PhotoName,
                PComment = PhotoModelMapping.MapCommentsEntityModel(photo.PComment),
               
            };
        }
    }
}