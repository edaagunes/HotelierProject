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
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(Contact entity)
		{
			_contactDal.Delete(entity);
		}

		public List<Contact> TGetAll()
		{
			return _contactDal.GetAll();
		}

		public Contact TGetById(int id)
		{
			return _contactDal.GetById(id);
		}

		public int TGetContactCount()
		{
			return _contactDal.GetContactCount();
		}

		public void TInsert(Contact entity)
		{
			_contactDal.Insert(entity);
		}

		public void TUpdate(Contact entity)
		{
			_contactDal.Update(entity);
		}
	}
}
