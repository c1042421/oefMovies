using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Display(Name = "Release Datum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int? Price { get; set; }
        public int RatingId { get; set; }

        public Rating Rating { get; set; }
    }

}
