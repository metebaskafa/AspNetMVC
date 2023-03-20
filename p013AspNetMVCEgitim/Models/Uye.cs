using System.ComponentModel.DataAnnotations;

namespace p013AspNetMVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad Alanı Boş Geçilemez!"),StringLength(50) ]// stringlenght ile ad alanına kaç karakter gönderebileceğimizi sınırlayabiliriz
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string Soyad { get; set; }
        [EmailAddress(ErrorMessage ="Geçersiz Mail Girdiniz!")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Geçersiz Telefon Girdiniz!")]
        public string? Telefon { get; set; }
        [Display(Name = "TC Kimlik Numarası ")] // ekranda tc kimlik numarası yazsın
        [MinLength(11, ErrorMessage ="{0} 11 karakter olmalıdır")]
        [MaxLength(11, ErrorMessage = "{0} 11 karakter olmalıdır")]
        public string? TcKimlikNo { get; set; }
        public DateTime? DoğumTarihi { get;set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public int? Sifre { get; set; }
        public int? SifreTekrar { get; set; }



    }
}
