using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewKunskapsKontroll.Models
{
    public class AdressBok
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime date { get; set; }
    }
}