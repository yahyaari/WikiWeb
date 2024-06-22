using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService<HomePage>
    {
        IHomePageDal _paragraphDal;

        public CategoryManager(IHomePageDal paragraphDal)
        {
            _paragraphDal = paragraphDal;
        }

        public void CategoryAdd(HomePage u)
        {
            _paragraphDal.Inset(u);
        }

        public void CategoryRemove(HomePage u)
        {
            _paragraphDal.Delete(u);
        }

        public void CategoryUpdate(HomePage u)
        {
            _paragraphDal.Update(u);
        }

        public List<HomePage> GetAllCategories()
        {
            return _paragraphDal.GetListAll();
        }


       
    }
}
