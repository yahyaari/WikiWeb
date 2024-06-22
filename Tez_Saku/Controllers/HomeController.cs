using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Homomorfik_Wiki.Models;

namespace Homomorfik_Wiki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // HomePageManager s�n�f�ndan bir �rnek olu�turulur ve veritaban� i�lemleri i�in kullan�l�r.
        HomePageManager cm = new HomePageManager(new EfHomePageRepoDAL());

        // Index metodu, "Index" sayfas�n�n ba�lang�� durumunu olu�turur ve g�r�nt�ler.
        public IActionResult Index()
        {
            // T�m kategorilerin veritaban�ndan al�nmas� i�in HomePageManager taraf�ndan GetAllCategories metodu �a�r�l�r.
            var values = cm.GetAllCategories();

            // Kategorilerin bulundu�u veri, "Index" sayfas�n�n g�r�n�m�ne g�nderilir.
            return View(values);
        }
        // Privacy metodu, "Privacy" sayfas�n� g�r�nt�ler.
        public IActionResult Privacy()
        {
            return View();
        }

        // Error metodu, hata durumunda "Error" sayfas�n� g�r�nt�ler.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata sayfas�na bir hata g�r�n�m modeli ile y�nlendirilir.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
