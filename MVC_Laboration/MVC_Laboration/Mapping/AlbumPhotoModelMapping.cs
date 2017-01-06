using System;
using System.Collections.Generic;
using System.Linq;
using MVCProjektData;
using MVCProjektData.Repositories;
using MVC_Laboration.Models;
using System.Web;

namespace MVC_Laboration.Mapping
{
    public class PhotoAlbumModelMapper
    {
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
            //AlbumID = photo.AlbumID
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
            //AlbumID = photo.AlbumID
        };
    }
    public static ICollection<AlbumModel> MapAlbumModel(ICollection<AlbumClass> album)
    {
        var result = new List<AlbumModel>();
        album.ToList().ForEach(x => result.Add(MapAlbumModel(x)));
        return result;
    }
    public static AlbumModel MapAlbumModel(AlbumClass album)
    {
        return new AlbumModel
        {
            AlbumId = album.AlbumId,
            AlbumName = album.AlbumName,
            AComment = album.Comment.Select(x => CommentsModelMapping.ModelToEntity(x)).ToList()
        };
    }
    public static ICollection<AlbumClass> MapAlbumEntityModel(ICollection<AlbumModel> comments)
    {
        var result = new List<AlbumClass>();
        comments.ToList().ForEach(x => result.Add(MapAlbumEntityModel(x)));
        return result;
    }
    public static AlbumClass MapAlbumEntityModel(AlbumModel album)
    {
        return new AlbumClass
        {
            AlbumId = album.AlbumId,
            AlbumName = album.AlbumName,
            Comment = album.AComment.Select(x => CommentsModelMapping.entitymodel(x)).ToList(),
            Photo = album.Photo.Select(x => PhotoModelMapping.EntityToModel(x)).ToList()
        };
    }
}
}