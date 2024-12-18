using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class SettingsController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public SettingsController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel viewModel = new UserEditViewModel();
			viewModel.Name = user.Name;
			viewModel.Email = user.Email;
			viewModel.Surname = user.Surname;
			viewModel.Username = user.UserName;
			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel model)
		{
			if (model.Password == model.ConfirmPassword)
			{
				var user = await _userManager.FindByNameAsync(User.Identity.Name);
				user.Name = model.Name;
				user.Email = model.Email;
				user.Surname = model.Surname;
				user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
	}
}
