using AutoMapper;
using SmartSchool.API.DTOs;
using SmartSchool.API.Helpers;
using SmartSchool.API.Models;

namespace SmartSchool.API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>()
                 .ForMember(
                    destiny => destiny.Name, 
                    origin => origin.MapFrom(
                        resource => $"{resource.Name} {resource.Surname}"))
                 .ForMember(
                    destiny => destiny.Age,
                    origin => origin.MapFrom( resource => DateTimeExtensions.GetCurrentAge(resource.BirthDate))
                    )
                .ReverseMap();

            CreateMap<Student, StudentRegistrationDTO>().ReverseMap();

            CreateMap<Teacher, TeacherDTO>()
                .ForMember(
                    destiny => destiny.Name,
                    origin => origin.MapFrom(
                        resource => $"{resource.Name} {resource.Surname}")
                    )
                .ReverseMap();

            CreateMap<Teacher, TeacherRegistrationDTO>().ReverseMap();

        }
    }
}
