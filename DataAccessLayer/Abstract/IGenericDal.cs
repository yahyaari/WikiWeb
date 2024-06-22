using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DataAccessLayer.Abstract namespace'i, veri erişim katmanı için soyut sınıfları içerir.
namespace DataAccessLayer.Abstract
{
    // IGenericDal arayüzü, genel veri erişim operasyonlarını tanımlar.
    // T, generic bir tip parametresidir ve bu arayüzü uygulayan sınıflar, belirli bir tip için veri erişim operasyonlarını gerçekleştirir.
    public interface IGenericDal<T> where T : class
    {
        // Belirtilen nesneyi veritabanına ekler.
        void Inset(T t);
        // Belirtilen nesneyi veritabanından siler.
        void Delete(T t);
        // Belirtilen nesneyi veritabanında günceller.
        void Update(T t);
        // Tüm nesnelerin listesini veritabanından alır.
        List<T> GetListAll();
        // Belirli bir nesneyi veritabanından id'ye göre alır.
        T GetById(int id);

    }
}
