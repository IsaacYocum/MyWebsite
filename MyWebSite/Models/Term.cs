using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Term
    {
        public virtual int TermId { get; set; }

        [Required]
        [Display(Name = "Term")]
        [StringLength(6, MinimumLength = 4)]
        public virtual string TermName { get; set; }
    }
}