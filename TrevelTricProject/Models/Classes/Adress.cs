using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrevelTricProject.Models.Classes
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanetion { get; set; }
        public string Address { get; set; }
        public string mail { get; set; }
        public string Phone { get; set; }
        public string Locasyon { get; set; }
    }
}