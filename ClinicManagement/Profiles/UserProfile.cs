using AutoMapper;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, DoctorViewModel>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Id));

            CreateMap<User, PatientViewModel>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.Id));

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id));

            CreateMap<User, UserEditViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
