using SEDC.CSharpAdv.VideoRental.Services.Helpers;
using SEDC.CSharpAdv.VideoRental.Services.Interfaces;
using SEDC.CSharpAdv.VideoRental.Services.Menu;
using SEDC.CSharpAdv.VideoRental.Services.Services;
using SEDC.CSharpAdv.VideoRentalData.Models;
using System;

namespace SEDC.CSharpAdv.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;

            IUserService userService = new UserService();
            MovieService movieService = new MovieService();

            #region Login/SignUp
            Screen.HomeScreen();

            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Screen.StartMenu();
                int startMenuInput = InputParser.ToInteger(1, 3);
                switch (startMenuInput)
                {
                    case 1:
                        user = userService.Login();
                        if(user != null)
                        {
                            isLoggedIn = true;
                        }
                        break;
                    case 2:
                        user = userService.SignUp();
                        if (user != null)
                        {
                            isLoggedIn = true;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            while (true)
            {
                Screen.ClearScreen();
                Screen.MainMenu(user.FullName);

                var selection = InputParser.ToInteger(1, 4);
                switch (selection)
                {
                    case 1:
                        movieService.ViewMovieList(user);
                        break;
                    case 2:
                        userService.ViewRentedMovies(user);
                        break;
                    case 3:
                        //to do 
                        break;
                    case 4:
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
