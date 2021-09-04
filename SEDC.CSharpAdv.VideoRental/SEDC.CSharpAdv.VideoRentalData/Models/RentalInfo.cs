using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRentalData.Models
{
    public class RentalInfo
    {
        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        public RentalInfo()
        {

        }

        public RentalInfo(Movie movie)
        {
            Movie = movie;
            DateReturned = DateTime.Now;
            DateReturned = null;
        }
    }
}
