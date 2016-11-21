using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    public class MyModel
    {
        public Guid ID { get; set; }
        public string ImgName {get; set;}
        public DateTime date { get; set; }
        //En Lista
        public IEnumerable<string> Images { get; set; }
    }
}