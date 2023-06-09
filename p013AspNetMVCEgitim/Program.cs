using p013AspNetMVCEgitim.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UyeContext>();// BU SATIRI SANAL VER�TABANI KULLANAB�LMEK ���N EKLED�K.   

builder.Services.AddSession(); // uygulamda session kullanabilmek i�in bu sat�r� ekliyoruz.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // uygulama http isteklerini https ile g�venli ba�lant�ya y�nlendirmeyi desteklesin.
app.UseStaticFiles(); // uygulama statik dosyalar� (wwwroot klas�r�ndekiler) desteklesin

app.UseSession();// uygulamda session kullanabilmek i�in bu sat�r� ekliyoruz.

app.UseRouting();// uygulama routing ile y�nlendirme kullans�n
app.UseAuthentication(); // uygulama kullan�c� giri� sistemini aktif etsin
app.UseAuthorization();// uygulama  kullan�c� yetkilendirme (admin user vb) sistemini aktif etsin

app.MapControllerRoute( // uygulaman�n kullanaca�� routing y�nlendirme ayar� 
    name: "default", // route ad�
    pattern: "{controller=Home}/{action=Index}/{id?}"); // e�er adres �ubu�undan uygulamaya bir controller ad� ve action ad� g�nderilmezse varsay�lan olarak home controller � ve i�indeki �ndex isimli action �al��t�rs�n . id de�eri ise ? i�areti ile parametrik yani iste�e ba�l� belirtilmi�.


app.Run();// uygulamay� yukar�daki ayarlar� kullanarak �al��t�r.
