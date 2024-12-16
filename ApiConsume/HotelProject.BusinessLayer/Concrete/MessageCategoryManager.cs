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
	public class MessageCategoryManager : IMessageCategoryService
	{
		private readonly IMessageCategoryDal _messageCategoryDal;

		public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
		{
			_messageCategoryDal = messageCategoryDal;
		}

		public void TDelete(MessageCategory entity)
		{
			_messageCategoryDal.Delete(entity);
		}

		public List<MessageCategory> TGetAll()
		{
			return _messageCategoryDal.GetAll();
		}

		public MessageCategory TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(MessageCategory entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(MessageCategory entity)
		{
			throw new NotImplementedException();
		}
	}
}
