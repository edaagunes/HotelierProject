﻿using AutoMapper;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;

namespace HotelProject.WebUI.Mapping
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<ResultServiceDto, Service>().ReverseMap();
			CreateMap<CreateServiceDto, Service>().ReverseMap();
			CreateMap<UpdateServiceDto, Service>().ReverseMap();

			CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
			CreateMap<LoginUserDto, AppUser>().ReverseMap();

			CreateMap<ResultAboutDto,About>().ReverseMap();
			CreateMap<UpdateAboutDto,About>().ReverseMap();

			CreateMap<ResultStaffDto,Staff>().ReverseMap();
		}
	}
}
