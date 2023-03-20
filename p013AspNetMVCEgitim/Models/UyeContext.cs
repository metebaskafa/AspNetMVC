using Microsoft.EntityFrameworkCore;

namespace p013AspNetMVCEgitim.Models
{
    // InMemoryDb kullanabilmek için projeye sağ tık nuget package manager menüsünü aç 
    // Oradan InMemory paketini ve Entity FrameCore.design paketlerini yüklüyoruz.
    public class UyeContext: DbContext
    {
        public DbSet<Uye> Uyes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //EntityFrameworkCore veritabanı işlemleri için yapılandırma ayarlarını yapabildiğimiz metot
            optionsBuilder.UseInMemoryDatabase("InMemoryDb"); // bilgisayarımızın ram belleğini sanal veritabanı olarak kullanılmasını sağlayan ayarı yaptık.bu ayardan sonra projemizin program.cs clasına gidip bu uyecontext sınıfını servis olarak ekliyoruz.
            base.OnConfiguring(optionsBuilder);
        }
    }
}
