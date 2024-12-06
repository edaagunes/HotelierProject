using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
		[Required(ErrorMessage ="Hizmet icon linki giriniz")]
		public string Icon { get; set; }
		[Required(ErrorMessage = "Hizmet adı giriniz")]
		[StringLength(50, ErrorMessage = "Hizmet adı en fazla 50 karakter olabilir")]
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
