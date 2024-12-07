using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
	public class _OurRoomsPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _OurRoomsPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			// İstemci oluşturduk
			var client = _httpClientFactory.CreateClient();

			// İstekte bulunduk (Listeleme olacağı için GetAsync) 
			var responseMessage = await client.GetAsync("http://localhost:5000/api/Room");

			if (responseMessage.IsSuccessStatusCode)
			{
				// Deserialize
				// Gelen veriyi Json'dan ViewModeldeki verilere dönüştürdük. json->string
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
