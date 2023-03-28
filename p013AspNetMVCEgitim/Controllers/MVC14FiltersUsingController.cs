using Microsoft.AspNetCore.Mvc;
using p013AspNetMVCEgitim.Filters;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC14FiltersUsingController : Controller
    {
        [UserControl] // kendi yazdığımız UserControl attribute ile bu ation a oturum açmayan kullanıcıların erişimini engelliyoruz.
        public IActionResult Index()
        {
            ViewBag.Kullanici = HttpContext.Session.GetString("UserGuid"); // UserGuid isimli session daki değeri yakala ve ViewBag.Kullanici ile Ekrana gönder
            return View();
        }
    }
}
