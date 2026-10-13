using Microsoft.AspNetCore.Mvc;

namespace practice.Controllers
{
    public class UserController : Controller
    {
        //localhost:port/user
        public IActionResult Index()
        {
            return View();
        }
    }
}
