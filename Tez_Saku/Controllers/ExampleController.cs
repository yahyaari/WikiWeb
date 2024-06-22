using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Homomorfik_Wiki.Controllers
{
    // ExampleController sınıfı, örnek bir kontrolcüdür ve "Example" işlemlerini yönetir.
    public class ExampleController : Controller
	{
        // ExampleManager sınıfından bir örnek oluşturulur ve veritabanı işlemleri için kullanılır.
        ExampleManager exampleManager = new ExampleManager(new EfExampleRepoDAL());

        // Index metodu, "Index" sayfasının başlangıç durumunu oluşturur ve görüntüler.
        public IActionResult Index()
		{
            // Tüm kategorilerin veritabanından alınması için ExampleManager tarafından GetAllCategories metodu çağrılır.
            var values = exampleManager.GetAllCategories();
            // Kategorilerin bulunduğu veri, "Index" sayfasının görünümüne gönderilir.
            return View(values);
		}
	}
}
