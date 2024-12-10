using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GuestController : ControllerBase
	{
		private readonly IGuestService _guestService;

		public GuestController(IGuestService guestService)
		{
			_guestService = guestService;
		}

		[HttpGet]
		public IActionResult GuestList()
		{
			var values = _guestService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddGuest(Guest guest)
		{
			_guestService.TInsert(guest);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteGuest(int id)
		{
			var values = _guestService.TGetById(id);
			_guestService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut]
		public IActionResult UpdateGuest(Guest guest)
		{
			_guestService.TUpdate(guest);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetGuest(int id)
		{
			var values = _guestService.TGetById(id);
			return Ok(values);
		}
	}
}
