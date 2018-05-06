using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Season
    {
        [Key]
        public int SeasonId { get; set; }

        [Required]
        [Display(Name = "Season")]
        [StringLength(6)]
        public string SeasonName { get; set; }

        public int YearId { get; set; }
    }
}