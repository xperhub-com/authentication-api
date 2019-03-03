﻿
using Nishaan.Solutions.XperhubAPI.Models.Entities;
using AutoMapper;

namespace Nishaan.Solutions.XperhubAPI.ViewModels.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}