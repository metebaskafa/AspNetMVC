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
        public IActionResult Index(string text1, string ddListe, bool cbOnay, IFormCollection formCollection)
        {
            ViewBag.Yontem1 = "1. Yöntemle(Parametreden gelen veriler)";
            ViewBag.Mesaj = "Textbox dan gelen veri : " + text1;
            ViewData["MesajListe"] = "ddListe dan gelen veri : " + ddListe;
            TempData["Tdata"] = "cbOnaydan gelen değer :" + cbOnay;

            ViewBag.Yontem2 = "2. Yöntemle(IFormCollection)";
            ViewBag.Mesaj2 = "Textbox dan gelen veri : " + formCollection["text1"];
            ViewData["MesajListe2"] = "ddListe dan gelen veri : " + formCollection["ddListe"];
            TempData["Tdata2"] = "cbOnaydan gelen değer :" + formCollection["cbOnay"][0];

            ViewBag.Yontem3 = "3. Yöntemle(RequestForm)";
            ViewBag.Mesaj3 = "Textbox dan gelen veri : " + Request.Form["text1"]; // formun içindeki yakaladığımız verileri veri tabanına yollamak için
            ViewData["MesajListe3"] = "ddListe dan gelen veri : " + Request.Form["ddListe"];
            TempData["Tdata3"] = "cbOnaydan gelen değer :" + Request.Form["cbOnay"][0];
            
            return View();
        }
    }
}
