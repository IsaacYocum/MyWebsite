using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        [Display(Name = "Class Acronym")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Must be between 2 and 10 characters long.")]
        public string ClassAcronym { get; set; }

        [Required]
        [Display(Name = "Number")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Must be between 2 and 4 characters long.")]
        public string ClassNum { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "50 characters maximum.")]
        public string ClassName { get; set; }

        public int SeasonId { get; set; }
    }
}