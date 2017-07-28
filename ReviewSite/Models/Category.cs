using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Make { get; set; }
        public bool TouchScreen { get; set; }
        public double ScreenSize { get; set; }
        public string OS { get; set; } //Operating System

        public virtual ICollection<Review> Reviews { get; set; }
    }
}