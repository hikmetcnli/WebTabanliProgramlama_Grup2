using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WP_Hafta2_1.Models;

namespace WP_Hafta2_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Kitap k1 = new Kitap();
            k1.Adi = "FELSEFE";
            k1.Yazar = "HİKMET";
            k1.Fiyat = 100;
            k1.Id = 1;

            Kitap k2 = new Kitap();
            k2.Adi = "matematil";
            k2.Yazar = "CANLI";
            k2.Fiyat = 100;
            k2.Id = 1;

            return View(k1);
        }
        public IActionResult KitapKayit()
        {
            return View();
        }
        public IActionResult Login(string Sonuc)
        {
            ViewData["Baslik"] = "Kullanıcı Giriş Ekranı";

            ViewBag.Baslik = "Kullanıcı Giriş Ekranı";

            if (Sonuc != null)
            {
                ViewBag.Mesaj = Sonuc;
            }
            else
            {
                ViewBag.Mesaj = "";
            }


                return View();
        }
        [HttpPost]
        public IActionResult LoginKontrol(User user)
        {

            if (user.Email == "hikmet.canli@gedik.edu.tr" && user.Password=="1" ) 
            {
                return RedirectToAction("Index", "Home", new { Sonuc = "OK" });
                 
            }
            else
            {
                return RedirectToAction("Login", "Home", new {Sonuc="NOK"});
            }
        
        }
        //metot tanımı
        //1. erişim tipi: Public, private, protected, internal
        //2. Hangi tipte geri değer dönecek: string, int, double, objecect, class, void
        //3. Metodun İsmi



    }
}
