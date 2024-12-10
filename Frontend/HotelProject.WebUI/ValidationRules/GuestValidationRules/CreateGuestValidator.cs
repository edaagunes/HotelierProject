using FluentValidation;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
	public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
	{
		public CreateGuestValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Misafir Adı Boş Geçilemez");
			RuleFor(x => x.Name).MinimumLength(3).WithMessage("Misafir Adı  En Az 3 Karakter Olmalıdır");
			RuleFor(x => x.Name).MaximumLength(20).WithMessage("Misafir Adı  En Fazla 20 Karakter Olmalıdır");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Misafir Soyadı Boş Geçilemez");
			RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Misafir Soyadı  En Az 3 Karakter Olmalıdır");
			RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Misafir Soyadı  En Fazla 20 Karakter Olmalıdır");
			RuleFor(x => x.City).NotEmpty().WithMessage("Misafir Şehir Bilgisi Boş Geçilemez");
			RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir Bilgisi En Az 3 Karakter Olmalıdır");
			RuleFor(x => x.City).MaximumLength(20).WithMessage("Şehir Bilgisi En Fazla 20 Karakter Olmalıdır");
		}
	}
}
