using SEDC.CSharpAdv.VideoRentalData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Interfaces
{
    public interface IMovieService
    {
        void ViewMovieList(User user);
    }
}
