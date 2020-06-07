using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
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
        public IActionResult Submission(Survey survey)
        {
            return View("Result", survey);
        }

    }

}