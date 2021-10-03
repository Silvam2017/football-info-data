using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace football_info_project.Models
{
    public class Quarterback
    {
        [Key]
        public int Id { get; set; }

        // Tag helper to set display name across the entire app.
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        //First QB statistic = Completion Percentage. 
        [Required]
        [Range(0,100, ErrorMessage ="Completion % can only be between 0 and 100%.")]
        public int Compl { get; set; }
    }
}
