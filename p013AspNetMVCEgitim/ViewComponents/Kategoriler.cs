using Microsoft.AspNetCore.Mvc;

namespace p013AspNetMVCEgitim.ViewComponents
{
    public class Kategoriler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // db ye bağlanıp kategorileri çekip componente gönderebiliriz
            return View();
        }
    }
}
