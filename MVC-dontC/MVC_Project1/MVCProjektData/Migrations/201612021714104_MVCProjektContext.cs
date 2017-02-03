namespace MVCProjektData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MVCProjektContext : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountClasses", newName: "AccountClass");
            RenameTable(name: "dbo.AlbumClasses", newName: "AlbumClass");
            RenameTable(name: "dbo.CommentClasses", newName: "CommentClass");
            RenameTable(name: "dbo.PhotoClasses", newName: "PhotoClass");
            RenameTable(name: "dbo.AlbumPhotoClasses", newName: "AlbumPhotoClass");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AlbumPhotoClass", newName: "AlbumPhotoClasses");
            RenameTable(name: "dbo.PhotoClass", newName: "PhotoClasses");
            RenameTable(name: "dbo.CommentClass", newName: "CommentClasses");
            RenameTable(name: "dbo.AlbumClass", newName: "AlbumClasses");
            RenameTable(name: "dbo.AccountClass", newName: "AccountClasses");
        }
    }
}
