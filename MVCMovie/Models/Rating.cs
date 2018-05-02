using System;
using System.Collections.Generic;

namespace MVCMovie.Models
{
    public partial class Rating
    {
        public Rating()
        {
            Movies = new HashSet<Movie>();
        }

        public int RatingId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
