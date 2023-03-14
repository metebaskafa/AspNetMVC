using Microsoft.AspNetCore.Mvc;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC01RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
