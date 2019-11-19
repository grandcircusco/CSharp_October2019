using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_27___SessionsRecap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Day_27___SessionsRecap.Controllers
{
    public class MovieDbController : Controller
    {
        //1. Create an empty, private List of Movies that will be used to access a session of saved movies.
        private List<Movies> userFavorites = new List<Movies>();
        private readonly Movie_DBContext _context;

        public MovieDbController(Movie_DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movieList = _context.Movies.ToList();
            return View(movieList);
        }

        public IActionResult AddToFavorites(int id)
        {
            var foundMovie = _context.Movies.Find(id);
            //5. Call the PopulateFavorites whenever you want to access the List of Favorited movies.
            PopulateFavorites();
            //6. Add the new favorite movie to the populated list of favorited movies.
            userFavorites.Add(foundMovie);
            //7. Set the session to the newly edited list of favorited movies.
            HttpContext.Session.SetString("FavoriteMovies", JsonConvert.SerializeObject(userFavorites));
            return View("ListFavorites", userFavorites);
        }

        //2. Create a method that checks to see if a session has already been created. 
        //3. We will get the session and store in a string.
        //4. If that string is then not empty, we will deserialize the string and store that in a List<Movies>.

        private void PopulateFavorites()
        {
            string movieListJson = HttpContext.Session.GetString("FavoriteMovies");
            if(movieListJson != null)
            {
                userFavorites = JsonConvert.DeserializeObject<List<Movies>>(movieListJson);
            }
        }
    }
}