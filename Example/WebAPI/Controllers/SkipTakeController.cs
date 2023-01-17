using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class SkipTakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
