using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entity
{
    public class BlogComment
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<CommentStatement> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}