using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture_3.Models
{
    public class Ingredient
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        [MinLength(50)]
        public string Description { get; set; }

        [Required]
        [Url]
        public string VideoLink { get; set; }
    }
}