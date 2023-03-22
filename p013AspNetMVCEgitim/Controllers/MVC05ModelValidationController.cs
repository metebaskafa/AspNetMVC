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
        public IActionResult UyeDuzenle(int id)
            
        {
            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul
            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeDuzenle(Uye uye)
        {
            if (ModelState.IsValid)// eğer parantez içerisinde gönderilen uyw nesnesi validasyon kurallarına uygunsa 
            {
                
                context.Uyes.Update(uye);// viewdan gönderilen uye nesnesini güncelle
                context.SaveChanges();  // üst satırdaki düzenleme işlemini kaydet
                return RedirectToAction("UyeListesi");
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!");
            }
            return View();
        }public IActionResult UyeSil(int id)
            
        {
            var kayit = context.Uyes.Find(id); // adres çubuğundaki route üzerinden gönderilen id ile eşleşen kaydı bul
            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyeSil(Uye uye)
        {
            try
            {
                context.Uyes.Remove(uye);// viewdan gönderilen uye nesnesini güncelle
                context.SaveChanges();  // üst satırdaki düzenleme işlemini kaydet
                return RedirectToAction("UyeListesi");
            }
            catch (Exception hata)
            {
                ModelState.AddModelError("", "Hata Oluştu"+ hata.Message);

            }
                
                
          
            return View(uye);
        }
    }
}
