using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite
{
    public class Review
    { 
        [Key]
        public int ReviewID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name ="Date")]
        public DateTime PublishDate { get; set; }
        [Display(Name ="How many stars would you rate this product?")]
        public int Stars { get; set; }
        public string Location { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}