using Microsoft.AspNetCore.Mvc;
using WP_Hafta2_1.Models;

namespace WP_Hafta2_1.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            Araba a1 = new Araba();
            a1.Id = 1;
            a1.Renk = "Kırmızı";
            a1.Yil = 2022;
            a1.Fiyat = 100;
            a1.Model = "Porche";


            return View(a1);
        }
        public IActionResult Details()
        { 
            var arabalar = new List<Araba> { 
            
                new Araba {Id=1,Model="Mercedes",Yil=2022,Fiyat=100,Renk="Beyaz"},
                new Araba {Id=2,Model="Porche",Yil=2023,Fiyat=100,Renk="Beyaz"},
                new Araba {Id=3,Model="Audi",Yil=2023,Fiyat=100,Renk="Kırmızı"},
                new Araba {Id=4,Model="BMW",Yil=2026,Fiyat=100,Renk="MAVİ"}            
            
            };
           

            return View(arabalar);
        }
    }
}
