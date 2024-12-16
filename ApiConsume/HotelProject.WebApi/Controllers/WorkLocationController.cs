using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkLocationController : ControllerBase
	{
		private readonly IWorkLocationService _workLocationService;

		public WorkLocationController(IWorkLocationService workLocationService)
		{
			_workLocationService = workLocationService;
		}

		[HttpGet]
		public IActionResult WorkLocationList()
		{
			var values = _workLocationService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddWorkLocation(WorkLocation workLocation)
		{
			_workLocationService.TInsert(workLocation);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteWorkLocation(int id)
		{
			var values = _workLocationService.TGetById(id);
			_workLocationService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut]
		public IActionResult UpdateWorkLocation(WorkLocation workLocation)
		{
			_workLocationService.TUpdate(workLocation);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetWorkLocationt(int id)
		{
			var values = _workLocationService.TGetById(id);
			return Ok(values);
		}
	}
}
