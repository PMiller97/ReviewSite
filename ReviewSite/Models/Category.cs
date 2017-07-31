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
        [Display(Name="Category")]
        public int CategoryID { get; set; }
        [Display(Name ="Phone Make")]
        public string Make { get; set; }
        [Display(Name ="Is it touchscreen?")]
        public bool TouchScreen { get; set; }
        //public double ScreenSize { get; set; }
        [Display(Name ="Operating System")]
        public string OS { get; set; } //Operating System

        public virtual ICollection<Review> Reviews { get; set; }
    }
}