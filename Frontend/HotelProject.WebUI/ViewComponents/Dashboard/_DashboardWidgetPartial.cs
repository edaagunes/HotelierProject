using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardWidgetPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("http://localhost:5000/api/DashboardWidgets/StaffCount");
			var responseMessage2 = await client.GetAsync("http://localhost:5000/api/DashboardWidgets/BookingCount");
			var responseMessage3 = await client.GetAsync("http://localhost:5000/api/DashboardWidgets/AppUserCount");
			var responseMessage4 = await client.GetAsync("http://localhost:5000/api/DashboardWidgets/RoomCount");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
				var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
				var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
				
				ViewBag.staff =jsonData;
				ViewBag.booking=jsonData2;
				ViewBag.appUser=jsonData3;
				ViewBag.room=jsonData4;
			}
			return View();
		}
	}
}
