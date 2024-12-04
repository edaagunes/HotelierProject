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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public void TDelete(Subscribe entity)
		{
			_subscribeDal.Delete(entity);
		}

		public List<Subscribe> TGetAll()
		{
			return _subscribeDal.GetAll();
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDal.GetById(id);
		}

		public void TInsert(Subscribe entity)
		{
			_subscribeDal.Insert(entity);
		}

		public void TUpdate(Subscribe entity)
		{
			_subscribeDal.Update(entity);
		}
	}
}
