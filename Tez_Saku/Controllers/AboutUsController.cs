using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Homomorfik_Wiki.Controllers
{
    // AboutUsController sınıfı, "Hakkımızda" sayfasının kontrolünü sağlar.
    public class AboutUsController : Controller
	{
        // Hakkımızda verilerini yönetmek için AboutUsManager nesnesi oluşturulur.
        // Bu nesne, Entity Framework kullanarak veri erişim işlemlerini gerçekleştirir.
        AboutUsManager aboutUsManager = new AboutUsManager(new EfAboutUsRepoDAL());

        // Index metodu, "Hakkımızda" sayfasının ana görünümünü oluşturur ve geri döndürür.
        public IActionResult Index()
		{
            // Tüm kategorilerin veritabanından alınması için AboutUsManager tarafından GetAllCategories metodu çağrılır.
            var values = aboutUsManager.GetAllCategories();

            // Kategorilerin bulunduğu veri, "Hakkımızda" sayfasının görünümüne gönderilir.
            return View(values);
		}
	}
}
