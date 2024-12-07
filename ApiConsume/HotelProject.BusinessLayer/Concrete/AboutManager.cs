using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TDelete(About entity)
		{
			_aboutDal.Delete(entity);
		}

		public List<About> TGetAll()
		{
			return _aboutDal.GetAll();
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public void TInsert(About entity)
		{
			_aboutDal.Insert(entity);
		}

		public void TUpdate(About entity)
		{
			_aboutDal.Update(entity);
		}
	}
}
