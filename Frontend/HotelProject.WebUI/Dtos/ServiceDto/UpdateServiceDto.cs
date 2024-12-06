using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
		public int ServiceId { get; set; }
		[Required(ErrorMessage = "Hizmet icon linki giriniz")]
		public string Icon { get; set; }
		[Required(ErrorMessage = "Hizmet adı giriniz")]
		[StringLength(50, ErrorMessage = "Hizmet adı en fazla 50 karakter olabilir")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Hizmet açıklaması giriniz")]
		[StringLength(500,ErrorMessage ="Hizmet açıklaması en fazla 500 karakter olabilir")]
		public string Description { get; set; }
	}
}
