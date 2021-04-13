using knchrazo.Application.Dtos;
using knchrazo.Domain.Entities;
using AutoMapper;

namespace knchrazo.Application.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UspGetEmployeeManagers, UspGetEmployeeManagersDTO>();
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<Person, PersonDTO>();

        }
    }
}
