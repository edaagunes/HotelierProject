using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
	public class CreateNewUserDto
	{
		[Required(ErrorMessage = "Adınızı Giriniz")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Soyadınızı Giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Kullanıcı adınızı Giriniz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Mail alanı Giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Şifrenizi Giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Şifrenizi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
		public string ConfirmPassword { get; set; }
	}
}
