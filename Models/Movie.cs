using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Movie
    {

        // The class with getters and setters for each property
        // they are all required except the last 3
        // Notes can't be longer than 25 characters

        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(maximumLength:25, ErrorMessage ="Notes cannot exceed 25 characters")]
        public string? Notes { get; set; }

    }
}
