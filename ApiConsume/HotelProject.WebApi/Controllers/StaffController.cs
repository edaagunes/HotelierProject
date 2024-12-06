﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values=_staffService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TInsert(staff);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			var values=_staffService.TGetById(id);
			_staffService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetStaff(int id)
		{
			var values= _staffService.TGetById(id);
			return Ok(values);
		}
	}
}