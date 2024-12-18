using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			var values = _bookingService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddBooking(Booking booking)
		{
			_bookingService.TInsert(booking);
			return Ok("Ekleme Başarılı");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			_bookingService.TDelete(values);
			return Ok("Silme Başarılı");
		}

		[HttpPut("UpdateBooking")]
		public IActionResult UpdateBooking(Booking booking)
		{
			_bookingService.TUpdate(booking);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			return Ok(values);
		}

		[HttpGet("BookingReservationApprover")]
		public IActionResult BookingReservationApprover(int id)
		{
			_bookingService.TBookingStatusChangeApproved(id);
			return Ok();
		}
		[HttpGet("BookingReservationCancel")]
		public IActionResult BookingReservationCancel(int id)
		{
			_bookingService.TBookingStatusChangeCancel(id);
			return Ok();
		}
		[HttpGet("BookingReservationWait")]
		public IActionResult BookingReservationWait(int id)
		{
			_bookingService.TBookingStatusChangeWait(id);
			return Ok();
		}

		[HttpGet("Last4Bookings")]
		public IActionResult Last4Bookings()
		{
			var values = _bookingService.TLast4Bookings();
			return Ok(values);
		}
	}
}
