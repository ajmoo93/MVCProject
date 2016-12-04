using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProjektData
{
    class PhotoClass
    {
        public Guid PhotoID { get; set; }
        public string ImgName { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<string> Image { get; set; }
        public virtual ICollection<CommentClass> Comment { get; set; }
    }
}
