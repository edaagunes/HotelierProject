using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TDelete(T entity);
		void TUpdate(T entity);
		List<T> TGetAll();
		T TGetById(int id);
	}
}
