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
            CreateMap<User, DoctorViewModel>();
        }
    }
}
