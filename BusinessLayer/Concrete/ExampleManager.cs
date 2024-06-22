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
	public class ExampleManager : ICategoryService<Example>
	{
		IGenericDal<Example> _exampleDal;
		public ExampleManager(IGenericDal<Example> exampleDal)
		{
			_exampleDal = exampleDal;
		}

		public void CategoryAdd(Example u)
		{
			_exampleDal.Inset(u);
		}

		public void CategoryRemove(Example u)
		{
			_exampleDal.Delete(u);
		}

		public void CategoryUpdate(Example u)
		{
			_exampleDal.Update(u);
		}

		public List<Example> GetAllCategories()
		{
			return _exampleDal.GetListAll();
		}
	}
}
