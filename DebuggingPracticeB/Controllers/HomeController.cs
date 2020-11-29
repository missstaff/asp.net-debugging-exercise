
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTown(string state, string city)
        {
            string content = "State: " + state + ", City: " + city;
            return Content(content);
        }

        [HttpPost]
        public IActionResult FavoriteMusic(string genre, string author, string book)
        {
            return Content("Genre: " + genre + ", Author: " + book + ", Book: " + author);
        }

        [HttpPost]
        public IActionResult Vacation(string location, string activity, string clothing)
        {
            string content = "Location: " + location + ", Activity: " + activity + ", What to wear: " + clothing;
            return Content(content);
        }

        [HttpPost]
        public IActionResult Reading(string genre, string author, string book)
        {
            string content = "Genre: " + genre + ", Author: " + author + ", Book: " + book;
            return Content(content);
        }

    }

}
