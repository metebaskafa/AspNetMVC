
using Microsoft.AspNetCore.Mvc;
using p013AspNetMVCEgitim.Models;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Yonlendir(string arananDeger)
        {
            //return Redirect("/Home"); // bu action tetiklendiğinde uygulama anasayfaya gitsin.
            //return Redirect($"/Home?kelime={arananDeger}"); // burada ? işaretinden sonraki kısım querystring yöntemi ile adres çubuğu üzerinden veri yollamak için 
            return Redirect("https://getbootstrap.com");
        }
        public IActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // metot çalıştığında aynı controllerdaki bir actiona yönlendirmemizi
            return RedirectToAction("Index", "Home"); // metot çalıştığında farklı bir controller daki actiona bu şekilde yönlendirebiliriz
        }
        public RedirectToRouteResult RouteYonlendir() //IActionResult da yapsaydık kabul ederdi.
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 }); // metot çalıştığında route sistemiyle yönlendirme yapmamızı sağlar
        }
        public PartialViewResult KategorileriGetirPartial() // IActionResult da yapsaydık kabul ederdi.
        {
            return PartialView("_KategorilerPartial");
        }
        public IActionResult XmlContentResult()
        {
            var xml = @"
                <Kullanicilar>
                <Kullanici>
                    <Adi>
                      Mete
                    </Adi>
                    <Soyadi>
                       Başkafa
                    </Soyadi>
                </Kullanici>
                    <Kullanici>
                    <Adi>
                      Alp
                    </Adi>
                    <Soyadi>
                       Arslan
                    </Soyadi>
                </Kullanici>
                </Kullanicilar>
            ";
            return Content(xml, "application/xml"); // geriye xml içeriğini döndürdük
        }
        public IActionResult JsonDondur()
        {

            var kullanici = new Kullanici()
            {
                Ad = "Alp",
                Soyad = "Çakmak",
                KullaniciAdi = "alpi"
            };
            return Json(kullanici);
        }
    }
}
