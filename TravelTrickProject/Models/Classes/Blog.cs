using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrickProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime History { get; set; }
        public string explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}