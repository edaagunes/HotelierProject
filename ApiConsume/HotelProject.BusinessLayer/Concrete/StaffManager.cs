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
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public List<Staff> TLast4Staff()
		{
			return _staffDal.Last4Staff();
		}

		public void TDelete(Staff entity)
		{
			_staffDal.Delete(entity);
		}

		public List<Staff> TGetAll()
		{
			return _staffDal.GetAll();
		}

		public Staff TGetById(int id)
		{
			return	_staffDal.GetById(id);
		}

		public int TGetStaffCount()
		{
			return _staffDal.GetStaffCount();
		}

		public void TInsert(Staff entity)
		{
			_staffDal.Insert(entity);
		}

		public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}
