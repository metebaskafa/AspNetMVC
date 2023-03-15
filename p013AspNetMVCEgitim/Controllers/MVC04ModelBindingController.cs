using Microsoft.AspNetCore.Mvc;
using p013AspNetMVCEgitim.Models;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult KullaniciDetay()
        {
            Kullanici kullanici = new();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Mete";
            kullanici.Soyad = "Başkafa";
            kullanici.Sifre = "123";
            kullanici.Email = "mete@baskafa.com";
            return View(kullanici); // View içerisinde model datası olarak kullanici nesnesini sayfaya gönderdik
        }
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici) // post metodunda modelden gelen nesneyi bu şekilde parantez içinde yakalayabiliriz
        {
            return View(kullanici); // gelen kullanici nesnesini tekrardan ekrana yollama
        }
        
        public IActionResult AdresDetay()
        {
            Adres adres = new()
            {
                Sehir = "Çankırı", Ilce = "Çerkeş", AcikAdres = "Çiçek skç No:18 A"
            };
            return View(adres);
        }
        public IActionResult UyeSayfasi()
        {
            Kullanici kullanici = new();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Mete";
            kullanici.Soyad = "Başkafa";
            kullanici.Sifre = "123";
            kullanici.Email = "mete@baskafa.com";
           
            Adres adres = new()
            {
                Sehir = "Çankırı",
                Ilce = "Çerkeş",
                AcikAdres = "Çiçek skç No:18 A"
            };

            var model = new UyeSayfasiViewModel()
            {
                Kullanici = kullanici,
                Adres = adres
            };
            return View(model);
        }
    }
}
