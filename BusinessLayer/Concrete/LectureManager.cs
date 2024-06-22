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
	public class LectureManager : ICategoryService<Lecture>
	{
		IGenericDal<Lecture> _lectureDal;
		public LectureManager(IGenericDal<Lecture> lectureDal)
		{
			_lectureDal = lectureDal;
		}

		public void CategoryAdd(Lecture u)
		{
			_lectureDal.Inset(u);
		}

		public void CategoryRemove(Lecture u)
		{
			_lectureDal.Delete(u);
		}

		public void CategoryUpdate(Lecture u)
		{
			_lectureDal.Update(u);
		}

		public List<Lecture> GetAllCategories()
		{
			return _lectureDal.GetListAll();
		}
	}
}
