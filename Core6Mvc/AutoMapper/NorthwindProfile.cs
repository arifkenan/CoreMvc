using AutoMapper;
using Core6Mvc.Models.DTO.Employees;
using Core6Mvc.Models.DTO.Products;
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

            CreateMap<Product, ProductListDTO>();
            

        }


    }
}
