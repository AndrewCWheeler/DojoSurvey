using Microsoft.AspNetCore.Mvc;
namespace YourProjectNameHere
{

    public class HomeController : Controller
    {
        // localhost:5000/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }    
    
        // localhost:5000/result
        [HttpPost]
        [Route("Result")]
        public IActionResult Result(string Name, string Dojo_Location, string Favorite_Language, string Comment)
        {
            ViewBag.name = Name; 
            ViewBag.dojo_location = Dojo_Location;
            ViewBag.favorite_language = Favorite_Language;
            ViewBag.comment = Comment;
            return View("Result");
        }

    }

}