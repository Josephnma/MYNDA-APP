using Microsoft.AspNetCore.Mvc;

namespace Mynda.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
