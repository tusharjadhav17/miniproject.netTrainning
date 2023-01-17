using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class TokanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
