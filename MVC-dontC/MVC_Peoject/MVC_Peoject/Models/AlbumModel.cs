using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Peoject.Models
{
    public class AlbumModel
    {
        public Guid AlbumID { get; set; }
        public string AlbumName { get; set; }
        public virtual ICollection<CommentModel> Comment { get; set; }
        public virtual ICollection<PhotoModel> Image { get; set; }
    }
}
GalleryContext db = new GalleryContext();
// GET: Photo
public ActionResult AlbumList()
{
    using (var context = new GalleryContext())
    {
        var NewAlbum = new AlbumClass();
        NewAlbum.AlbumID = Guid.NewGuid();
        NewAlbum.AlbumName = "wowowowow";
        context.album.Add(NewAlbum);
        context.SaveChanges();
    }

    return View(db.album.ToList());
}