using Microsoft.AspNetCore.Mvc;
using p013AspNetMVCEgitim.Models;

namespace p013AspNetMVCEgitim.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            var model = context.Uyes.ToList();// Context içinde yer alan Uyes tablosundaki verileri Listele ve model isimli değişkene aktar.
            return View(model);
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)// eğer parantez içerisinde gönderilen uyw nesnesi validasyon kurallarına uygunsa 
            {
                // bu bloktaki kodları çalıştır.mesela gönderilen uye nesnesini verityabanına ekle
                context.Uyes.Add(uye);// viewdan gönderilen uye nesnesini context üzerinde uyes tablosuna ekle
                context.SaveChanges();  // üst satırdaki ekleme işlemini kaydet
                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!");
            }
            return View();
        }
    }
}
