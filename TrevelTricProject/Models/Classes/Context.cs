using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrevelTricProject.Models.Classes
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}