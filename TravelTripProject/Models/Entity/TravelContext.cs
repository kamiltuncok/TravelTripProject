using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProject.Models.Entity
{
    public class TravelContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AddressStatement> AddressStatements { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CommentStatement> CommentStatements { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}