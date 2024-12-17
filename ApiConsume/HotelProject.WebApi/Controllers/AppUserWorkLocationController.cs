using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppUserWorkLocationController : ControllerBase
	{
		private readonly IAppUserService _appUserService;

		public AppUserWorkLocationController(IAppUserService appUserService)
		{
			_appUserService = appUserService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			//var values = _appUserService.TUsersListWithWorkLocations();
			Context context = new Context();
			var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
			{
				Name = y.Name,
				Surname = y.Surname,
				WorkLocationId = y.WorkLocationId,
				WorkLocationName = y.WorkLocation.Name,
				City = y.WorkLocation.City,
				Country = y.Country,
				Gender = y.Gender,
				ImageUrl = y.ImageUrl
			}).ToList();
			return Ok(values);
		}
	}
}
