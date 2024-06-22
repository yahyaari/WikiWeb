using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // ICategoryService arayüzü, genel kategori hizmetlerini tanımlar.
    // T, generic bir tip parametresidir ve bu arayüzü uygulayan sınıflar, belirli bir tip için kategori hizmetlerini sağlar.
    public interface ICategoryService<T> where T : class
    {
        void CategoryAdd(T u);
        void CategoryRemove(T u);
        void CategoryUpdate(T u);
        List<T> GetAllCategories();
        

    }
}
