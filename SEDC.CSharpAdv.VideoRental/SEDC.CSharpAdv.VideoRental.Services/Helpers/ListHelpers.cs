using SEDC.CSharpAdv.VideoRentalData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Helpers
{
    public static class ListHelpers
    {
        public static void PrintMovies(this List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(Movie.GetMovieInfo(movie));
            }
        }
    }
}
