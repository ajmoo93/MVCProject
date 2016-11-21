using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    public class ContreollerModel
    {
       public IList<Comment> comments { get; set; }
        public ContreollerModel()
        {
            comments = new List<Comment>();
        }
    }
    
}