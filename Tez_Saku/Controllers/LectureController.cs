using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Homomorfik_Wiki.Controllers
{
	public class LectureController : Controller
	{
        // LectureManager sınıfından bir örnek oluşturulur ve veritabanı işlemleri için kullanılır.
        LectureManager lectureManager = new LectureManager(new EfLectureRepoDAL());

		public IActionResult Index()
		{
            // Tüm kategorilerin veritabanından alınması için LectureManager tarafından GetAllCategories metodu çağrılır.
            var values = lectureManager.GetAllCategories();

            // Kategorilerin bulunduğu veri, "Index" sayfasının görünümüne gönderilir.
            return View(values);
		}
	}
}
