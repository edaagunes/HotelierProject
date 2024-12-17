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
	public class AppUserManager : IAppUserService
	{
		private readonly IAppUserDal _appUserDal;

		public AppUserManager(IAppUserDal appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public int TAppUserCount()
		{
			return _appUserDal.AppUserCount();
		}

		public void TDelete(AppUser entity)
		{
			_appUserDal.Delete(entity);
		}

		public List<AppUser> TGetAll()
		{
			return _appUserDal.GetAll();
		}

		public AppUser TGetById(int id)
		{
			return _appUserDal.GetById(id);
		}

		public void TInsert(AppUser entity)
		{
			_appUserDal.Insert(entity);
		}

		public void TUpdate(AppUser entity)
		{
			_appUserDal.Update(entity);
		}

		public List<AppUser> TUserListWithWorkLocation()
		{
			return _appUserDal.UserListWithWorkLocation();
		}

		public List<AppUser> TUsersListWithWorkLocations()
		{
			return _appUserDal.UsersListWithWorkLocations();
		}
	}
}
