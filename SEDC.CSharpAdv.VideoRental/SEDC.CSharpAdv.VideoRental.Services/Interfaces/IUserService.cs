using SEDC.CSharpAdv.VideoRentalData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Interfaces
{
    public interface IUserService
    {
        User Login();
        User SignUp();
        void ViewRentedMovies(User user);
    }
}
