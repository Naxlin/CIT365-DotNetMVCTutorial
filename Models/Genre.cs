using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string GenreName { get; set; }
    }
}