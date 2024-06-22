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

        // HomePageManager sýnýfýndan bir örnek oluþturulur ve veritabaný iþlemleri için kullanýlýr.
        HomePageManager cm = new HomePageManager(new EfHomePageRepoDAL());

        // Index metodu, "Index" sayfasýnýn baþlangýç durumunu oluþturur ve görüntüler.
        public IActionResult Index()
        {
            // Tüm kategorilerin veritabanýndan alýnmasý için HomePageManager tarafýndan GetAllCategories metodu çaðrýlýr.
            var values = cm.GetAllCategories();

            // Kategorilerin bulunduðu veri, "Index" sayfasýnýn görünümüne gönderilir.
            return View(values);
        }
        // Privacy metodu, "Privacy" sayfasýný görüntüler.
        public IActionResult Privacy()
        {
            return View();
        }

        // Error metodu, hata durumunda "Error" sayfasýný görüntüler.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata sayfasýna bir hata görünüm modeli ile yönlendirilir.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
