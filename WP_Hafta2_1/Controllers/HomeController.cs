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
            return View();
        }
        public IActionResult KitapKayit()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public void LoginKontrol(User user)
        {
        
        }
        //metot tanımı
        //1. erişim tipi: Public, private, protected, internal
        //2. Hangi tipte geri değer dönecek: string, int, double, objecect, class, void
        //3. Metodun İsmi



    }
}
