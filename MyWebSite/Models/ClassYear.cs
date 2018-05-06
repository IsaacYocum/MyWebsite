using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class ClassYear
    {
        [Key]
        public int YearId { get; set; }

        [Required]
        [Range(2015, 2021, ErrorMessage = "Year must be between 2015 and 2021")]
        public int Year { get; set; }
    }
}