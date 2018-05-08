using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }

        [Required]
        [Display(Name = "Acronym")]
        [StringLength(4, MinimumLength = 2)]
        public virtual string CourseAcronym { get; set; }

        [Required]
        [Display(Name = "Number")]
        [StringLength(4, MinimumLength = 2)]
        public virtual string CourseNum { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(255)]
        public virtual string CourseDescription { get; set; }

        [Required]
        [Display(Name = "Term")]
        public virtual int TermId { get; set; }

        [Required]
        [Display(Name = "Year")]
        public virtual int CourseYearId { get; set; }

        public virtual Term Term { get; set; }
        public virtual CourseYear CourseYear { get; set; }
    }
}