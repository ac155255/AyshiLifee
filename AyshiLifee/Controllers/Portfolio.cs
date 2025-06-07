using Microsoft.AspNetCore.Mvc;

namespace AyshiLifee.Controllers
{
    public class Portfolio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
