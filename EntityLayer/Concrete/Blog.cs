﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        
        public int BlogId { get; set; }
        public String? BlogTitle { get; set; }
        public String? BlogContent { get; set; }
        public String? BlogThumbnailImage { get; set; }
        public String? BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        public int  CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
