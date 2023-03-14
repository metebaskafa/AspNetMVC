using Microsoft.AspNetCore.Mvc;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public IActionResult Index(string Ara) // get metoduyla gönderilen verileri bu şekilde string Ara yazarak yakalayabilirizi
        {
            // mvc de temel olarak 3 farklı yöntemle ekrana veri gönderebiliriz
            // 1 ViewBag : Tek kullanımlık ömrü vardır.
            ViewBag.UrunKategorisi = "Bilgisayar";
            // 2 ViewData : tek kullanımlık ömrü var
            ViewData["UrunAdi"] = "Asus Dizüstü Bilgisayar";
            // 3 TempData :  2 kullanımlık ömrü var
            TempData["UrunFiyati"] = 9999;

            ViewBag.GetVerisi = Ara;
            return View();
        }
        [HttpPost] 
        public IActionResult Index(string text1, string ddListe, bool cbOnay)
        {
            ViewBag.BirinciYontem = "1. Yöntemle(Parametreden gelen veriler)";
            ViewBag.Mesaj = "Textbox dan gelen veri : " + text1;
            ViewBag.MesajListe = "ddListe dan gelen veri : " + ddListe;
            TempData["Tdata"] = "cbOnaydan gelen değer :" + cbOnay;
            return View();
        }
    }
}
