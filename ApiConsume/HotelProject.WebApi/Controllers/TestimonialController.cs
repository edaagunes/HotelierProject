﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var values = _testimonialService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.TInsert(testimonial);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete]
		public IActionResult DeleteTestimonial(int id)
		{
			var values = _testimonialService.TGetById(id);
			_testimonialService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var values = _testimonialService.TGetById(id);
			return Ok(values);
		}
	}
}
