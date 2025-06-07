
using Microsoft.AspNetCore.Mvc;

namespace AyshisLife.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email, string message)
        {
            // You can handle the message here (save to DB, send email, etc.)
            ViewBag.MessageSent = true;
            return View();
        }
    }
}
