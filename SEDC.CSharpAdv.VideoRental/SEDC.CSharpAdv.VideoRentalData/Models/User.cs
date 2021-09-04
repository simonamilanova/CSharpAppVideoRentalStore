using SEDC.CSharpAdv.VideoRentalData.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRentalData.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public int CardNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }
        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentalHistory { get; set; }
        public int Age 
        {
            get 
            {

                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public User()
        {
            RentalHistory = new List<RentalInfo>();
            RentedMovies = new List<RentalInfo>();

        }

        public void ViewRentedMovies()
        {
            if(RentedMovies.Count == 0)
            {
                Console.WriteLine("There are no rented movies.");
            } 
            else
            {
                foreach (var rental in RentedMovies)
                {
                    Console.WriteLine($"{rental.Movie.Title} rented at {rental.DateRented}");
                }
            }
        }
    }
}
