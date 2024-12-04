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
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TDelete(Service entity)
		{
			_serviceDal.Delete(entity);
		}

		public List<Service> TGetAll()
		{
			return _serviceDal.GetAll();
		}

		public Service TGetById(int id)
		{
			return _serviceDal.GetById(id);
		}

		public void TInsert(Service entity)
		{
			_serviceDal.Insert(entity);
		}

		public void TUpdate(Service entity)
		{
			_serviceDal.Update(entity);
		}
	}
}
