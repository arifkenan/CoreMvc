using AutoMapper;
using Core6Mvc.Models.DTO.Employees;
using Nortwhind.Entities;

namespace Core6Mvc.AutoMapper
{
    public class NorthwindProfile:Profile
    {
        public NorthwindProfile()
        {
            CreateMap<Employee, EmployeeListDto>();
            CreateMap<EmployeeCreateDto, Employee>();


            CreateMap<Employee, EmployeeUpdateDto>();
            CreateMap<EmployeeUpdateDto, Employee>();
        }


    }
}
