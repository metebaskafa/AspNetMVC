using Microsoft.AspNetCore.Mvc;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC13AppSettingController : Controller
    {
        private readonly IConfiguration _configuration;

        public MVC13AppSettingController(IConfiguration configuration) // dependency injection ile constructor da oluşturmak için _configuration a sağ tık açılan meniden ampul simgesine tıklayıp açılan menüden generate constructor diyerek oluşturabiliriz.
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            TempData["Email"] = _configuration["Email"];
            TempData["MailSunucu"] = _configuration["MailSunucu"];
            TempData["KullaniciAdi"] = _configuration["MailKullanici:Username"];// jsondaki mailkullanici altındaki username değerine : ile ulaşıyoruz
            TempData["Sifre"] = _configuration.GetSection("MailKullanici:Password").Value; // getsection metoduyla da veriyi çekebiliriz. 
            return View();
        }
    }
}
