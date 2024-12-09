using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidApiConsume.Models;
using Newtonsoft.Json;
using System.Linq;

namespace RapidApiConsume.Controllers
{
	public class SearchLocationIdController : Controller
	{
		public async Task<IActionResult> Index(string cityName)
		{
			if (!string.IsNullOrEmpty(cityName))
			{
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={cityName}"),
					Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}
			}

			else
			{
				List<BookingApiLocationSearchViewModel> model = new List<BookingApiLocationSearchViewModel>();
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name=Paris"),
					Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "booking-com.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
					return View(model.Take(1).ToList());
				}
			}

		}
	}
}

