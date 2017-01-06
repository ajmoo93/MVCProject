using System;
using System.Collections.Generic;
using System.Linq;
using MVCProjektData;
using MVCProjektData.Repositories;
using MVC_Laboration.Models;
using System.Web;

namespace MVC_Laboration.Mapping
{
    public class CommentsModelMapping
    {
        public static CommentClass entitymodel(CommentModel comments)
        {
            CommentClass entity = new CommentClass();
            entity.Id = comments.Id;
            entity.CommentOnPhoto = comments.CommentPhoto;
            entity.CommentOnAlbum = comments.CommentAlbum;
            return entity;
        }
        public static CommentModel ModelToEntity(CommentClass comments)
        {
            CommentModel model = new CommentModel();
            model.Id = comments.Id;
            model.CommentPhoto = comments.CommentOnPhoto;
            model.CommentAlbum = comments.CommentOnAlbum;
            return model;
        }
    }
}