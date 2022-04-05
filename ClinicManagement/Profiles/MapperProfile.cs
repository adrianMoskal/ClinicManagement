using AutoMapper;
using ClinicManagement.Entities;
using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            AddUserMapping();
            AddPatientMapping();
            AddDoctorMapping();
            AddAppointmentMapping();
            AddAppointmentHourMapping();
            AddSpecialtyMapping();
            AddPrescriptionMapping();
            AddMedicineMapping();
        }

        #region User

        public void AddUserMapping()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id));

            CreateMap<User, UserEditViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id));

            CreateMap<User, UserProfileViewModel>()
                .ForMember(dest => dest.Appointments, opt => opt.MapFrom(src => src.AppointmentsDoc.Any() ? src.AppointmentsDoc : src.AppointmentsPat));
        }

        #endregion

        #region Patient

        public void AddPatientMapping()
        {
            CreateMap<User, PatientViewModel>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }

        #endregion

        #region Doctor

        public void AddDoctorMapping()
        {
            CreateMap<User, DoctorViewModel>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Specialties, opt => opt.MapFrom(src => string.Join(", ", src.UserSpecialties.Select(us => us.Specialty.Name))));
        }

        #endregion

        #region Appointment

        public void AddAppointmentMapping()
        {
            CreateMap<Appointment, AppointmentViewModel>()
                .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => $"{src.Doctor.FirstName} {src.Doctor.LastName}"))
                .ForMember(dest => dest.DoctorUserName, opt => opt.MapFrom(src => src.Doctor.UserName))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => $"{src.Patient.FirstName} {src.Patient.LastName}"))
                .ForMember(dest => dest.PatientUserName, opt => opt.MapFrom(src => src.Patient.UserName))
                .ForMember(dest => dest.Hour, opt => opt.MapFrom(src => src.Hour.Hour));

            CreateMap<AppointmentCreateViewModel, Appointment>()
                .ForMember(dest => dest.AppointmentHourId, opt => opt.MapFrom(src => src.HourId))
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.Now));
        }

        #endregion

        #region AppointmentHour

        public void AddAppointmentHourMapping()
        {
            CreateMap<AppointmentHour, AvailableHourViewModel>()
                .ForMember(dest => dest.HourId, opt => opt.MapFrom(src => src.Id));
        }

        #endregion

        #region Specialties

        public void AddSpecialtyMapping()
        {
            CreateMap<Specialty, SpecialtyViewModel>()
                .ForMember(dest => dest.SpecialtyId, opt => opt.MapFrom(src => src.Id));
        }

        #endregion

        #region Prescriptions

        public void AddPrescriptionMapping()
        {
            CreateMap<Prescription, PrescriptionViewModel>()
                .ForMember(dest => dest.PrescriptionId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => $"{src.Doctor.FirstName} {src.Doctor.LastName}"))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => $"{src.Patient.FirstName} {src.Patient.LastName}"))
                .ForMember(dest => dest.MedicineName, opt => opt.MapFrom(src => src.Medicine.Name))
                .ForMember(dest => dest.MedicinePrice, opt => opt.MapFrom(src => $"{src.Medicine.Price} $"))
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.CreateDate.ToString()))
                .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate.ToString()))
                .ForMember(dest => dest.CollectedDate, opt => opt.MapFrom(src => src.CollectedDate != null ? src.CollectedDate.ToString() : ""));

            CreateMap<PrescriptionCreateViewModel, Prescription>()
                .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => DateTime.Now.AddDays(7)));
        }

        #endregion

        #region Medicine

        public void AddMedicineMapping()
        {
            CreateMap<Medicine, MedicineViewModel>()
                .ForMember(dest => dest.MedicineId, opt => opt.MapFrom(src => src.Id));
        }

        #endregion
    }
}
