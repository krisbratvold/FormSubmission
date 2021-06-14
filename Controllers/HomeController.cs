using FormSubmission.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("/process")]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Result");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        [HttpGet("/result")]
        public IActionResult Result()
        {
            return View("Result");
        }
    }
}