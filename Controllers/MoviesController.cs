using dawp_lecture_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dawp_lecture_2.Controllers;
    public class MoviesController : Controller
    {
        private static List<MovieViewModel> Movies = [
            new MovieViewModel()
            {
                Id = 1,
                Title = "Shrek",
                Overview = "GAREASD ASDSD",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0NGIwM2EtZjQxZi00ZTE5LWExN2MtNDBlMjY1ZmZkYjU3XkEyXkFqcGdeQXVyNjMwNzk3Mjk@._V1_QL75_UX240_CR0,1,240,350_.jpg"
            },
            new MovieViewModel()
            {
                Id = 2,
                Title = "Shrek 2",
                Overview = "GAREASD ASDSD",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0NGIwM2EtZjQxZi00ZTE5LWExN2MtNDBlMjY1ZmZkYjU3XkEyXkFqcGdeQXVyNjMwNzk3Mjk@._V1_QL75_UX240_CR0,1,240,350_.jpg"
            },
            new MovieViewModel()
            {
                Id = 3,
                Title = "Shrek 3",
                Overview = "GAREASD ASDSD",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0NGIwM2EtZjQxZi00ZTE5LWExN2MtNDBlMjY1ZmZkYjU3XkEyXkFqcGdeQXVyNjMwNzk3Mjk@._V1_QL75_UX240_CR0,1,240,350_.jpg"
            },
            new MovieViewModel()
            {
                Id = 4,
                Title = "Shrek 4",
                Overview = "GAREASD ASDSD",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0NGIwM2EtZjQxZi00ZTE5LWExN2MtNDBlMjY1ZmZkYjU3XkEyXkFqcGdeQXVyNjMwNzk3Mjk@._V1_QL75_UX240_CR0,1,240,350_.jpg"
            },



        ]; 
        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult Details(int id)
        {
            var movie = Movies.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }
}

