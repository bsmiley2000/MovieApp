using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Category { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public int Year { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public string Director { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public string Rating { get; set; }


        public string Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25, ErrorMessage = "Notes field can only have 25 characters")]
        public string Notes { get; set; }

  


    }
}
