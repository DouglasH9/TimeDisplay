using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet ("")]
        public IActionResult ShowTime()
        {
            return View();
        }
    }
}

