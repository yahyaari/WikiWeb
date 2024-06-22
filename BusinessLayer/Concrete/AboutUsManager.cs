using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    // AboutUsManager sınıfı, AboutUs varlıkları için kategori hizmetlerini yönetir.
    public class AboutUsManager : ICategoryService<AboutUs>
	{
        // AboutUs varlıkları üzerinde genel veritabanı işlemlerini gerçekleştiren IGenericDal arayüzünden bir örnek.
        IGenericDal<AboutUs> _aboutusDal;

        // AboutUsManager sınıfının yapıcı metodu.
        public AboutUsManager(IGenericDal<AboutUs> aboutusDal)
		{
			_aboutusDal = aboutusDal; // Dependency Injection ile gelen IGenericDal nesnesini alır.
        }
        // Yeni bir AboutUs varlığı ekler.
        public void CategoryAdd(AboutUs u)
		{
			_aboutusDal.Inset(u);
		}
        // Varolan bir AboutUs varlığını kaldırır.
        public void CategoryRemove(AboutUs u)
		{
			_aboutusDal.Delete(u);
		}
        // Varolan bir AboutUs varlığını günceller.
        public void CategoryUpdate(AboutUs u)
		{
			_aboutusDal.Update(u);
		}
        // Tüm AboutUs varlıklarının listesini alır.
        public List<AboutUs> GetAllCategories()
		{
			return	_aboutusDal.GetListAll();
		}
	}
}
