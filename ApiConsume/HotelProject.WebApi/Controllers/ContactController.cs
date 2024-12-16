﻿using HotelProject.BusinessLayer.Abstract;
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
		public IActionResult AddContact(Contact contact)
		{
			contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
			 _contactService.TInsert(contact);
			return Ok("Ekleme Başarılı");
		}

		[HttpGet]
		public IActionResult InboxListContact()
		{
			var values=_contactService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetSendMessage(int id)
		{
			var values = _contactService.TGetById(id);
			return Ok(values);
		}

		[HttpGet("GetContactCount")]
		public IActionResult GetContactCount()
		{
			return Ok(_contactService.TGetContactCount());
		}
	}
}
