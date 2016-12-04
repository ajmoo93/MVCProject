using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData
{
    public class AccountClass
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CommentModel> comment { get; set; }
        public virtual ICollection<PhotoModel> photo { get; set; }
        public virtual ICollection<AlbumModel> album { get; set; }
    }
}
