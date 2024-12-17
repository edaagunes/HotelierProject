using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardSubscribeCountPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
	//		var client = new HttpClient();
	//		var request = new HttpRequestMessage
	//		{
	//			Method = HttpMethod.Get,
	//			RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/therock"),
	//			Headers =
	//{
	//	{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
	//	{ "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
	//},
	//		};
	//		using (var response = await client.SendAsync(request))
	//		{
	//			response.EnsureSuccessStatusCode();
	//			var body = await response.Content.ReadAsStringAsync();
	//			ResultInstagramFollowersDto dto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);

	//			ViewBag.instaFollower = dto.followers;
	//			ViewBag.instaFollowing = dto.following;

	//		}

			// Twitter
			//var client2 = new HttpClient();
			//var request2 = new HttpRequestMessage
			//{
			//	Method = HttpMethod.Get,
			//	RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=therock"),
			//	Headers =
			//{
			//	{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
			//	{ "x-rapidapi-host", "twitter32.p.rapidapi.com" },
			//},
			//};
			//using (var response2 = await client2.SendAsync(request))
			//{
			//	response2.EnsureSuccessStatusCode();
			//	var body2 = await response2.Content.ReadAsStringAsync();
			//	ResultTwitterFollowersDto dto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
			//	ViewBag.twitFollower = dto.data.user_info.followers_count;
			//	ViewBag.twitFollowing = dto.data.user_info.friends_count;
			//}

			// Linkedin
	//		var client3 = new HttpClient();
	//		var request3 = new HttpRequestMessage
	//		{
	//			Method = HttpMethod.Get,
	//			RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fedaagunes%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
	//			Headers =
	//{
	//	{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
	//	{ "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	//},
	//		};
	//		using (var response3 = await client3.SendAsync(request))
	//		{
	//			response3.EnsureSuccessStatusCode();
	//			var body3 = await response3.Content.ReadAsStringAsync();
	//			ResultLinkedinFollowersDto dto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
	//			ViewBag.linkedinFollower = dto.data.follower_count;
	//			ViewBag.linkedinFollowing = dto.data.connection_count;
	//		}
			return View();
		}
	}
}
