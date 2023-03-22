using Microsoft.AspNetCore.Mvc;
using p013AspNetMVCEgitim.Models;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC07PartialController : Controller
    {
        public IActionResult Index()
        {
            Kullanici kullanici= new Kullanici();
            kullanici.Ad = "mete";
            kullanici.Soyad = "başkafa";
            return View(kullanici);
        }
    }
}
