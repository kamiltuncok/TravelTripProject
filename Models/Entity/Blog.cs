﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entity
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<CommentStatement> CommentStatements { get; set; }
    }
}