using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;

		public ContactController(IContactService bookingService)
		{
			_contactService = bookingService;
		}

		[HttpPost]
		public IActionResult ContactList(Contact contact)
		{
			contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
			 _contactService.TInsert(contact);
			return Ok("Ekleme Başarılı");
		}
	}
}
