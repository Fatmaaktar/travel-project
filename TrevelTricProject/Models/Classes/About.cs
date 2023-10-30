using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrevelTricProject.Models.Classes
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string explanation { get; set; }
    }
}