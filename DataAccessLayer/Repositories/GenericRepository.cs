using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessLayer.Repositories
{
    //Bu sınıf CRUD(Create, Read, Update, Delete) işlemlerini gerçekleştirir.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            // Veritabanı bağlantısı oluşturulur ve işlem tamamlanıncaya kadar bağlantı açık tutulur.
            using var c = new Context();
            c.Remove(t); //Belirtilen nesneyi veritabanından kaldırır.
            c.SaveChanges(); // Yapılan değişiklikleri kaydeder.
        }
        // Belirli bir nesneyi veritabanından id'ye göre alır.
        public T GetById(int id)
        {

            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        // Tüm nesnelerin listesini veritabanından alır.
        public List<T> GetListAll()
        {
            // Veritabanı bağlantısı oluşturulur ve işlem tamamlanıncaya kadar bağlantı açık tutulur.
            using var c = new Context();
            return c.Set<T>().ToList(); // Tüm nesnelerin listesini alır.
        }
  
        public void Inset(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
