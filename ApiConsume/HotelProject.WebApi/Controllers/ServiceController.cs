﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var values = _serviceService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.TInsert(service);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteService(int id)
		{
			var values = _serviceService.TGetById(id);
			_serviceService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.TUpdate(service);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var values = _serviceService.TGetById(id);
			return Ok(values);
		}
	}
}
