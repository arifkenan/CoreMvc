using AutoMapper;
using Core6Mvc.Models.DTO.Employees;
using Microsoft.AspNetCore.Mvc;
using Nortwhind.Entities;

namespace Core6Mvc.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly NorthwindContext context;
        private readonly IMapper mapper;

        public EmployeeController(NorthwindContext context,IMapper mapper)
        {

            this.context = context;
            this.mapper = mapper;
            
        }

        public IActionResult Index()
        {
            List<EmployeeListDto> listDtos = new List<EmployeeListDto>();

            var EmployeeList = context.Employees.ToList();

        //    foreach (var employee in EmployeeList)
        //    {
        //        EmployeeListDto listDto = new();
        //        listDto.Id = employee.EmployeeId;
        //        listDto.FirstName = employee.FirstName;
        //        listDto.LastName = employee.LastName;
        //        listDto.HireDate = employee.HireDate;
        //        listDto.Country = employee.Country;
        //        listDto.City = employee.City;
        //        listDto.HomePhone = employee.HomePhone;
        //        listDtos.Add(listDto);
        //    }

        //    return View(listDtos);

            IList<EmployeeListDto> calisanlar = mapper.Map<IList<EmployeeListDto>>(EmployeeList);
            return View(calisanlar);

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           var calisan = context.Employees.FirstOrDefault(p => p.EmployeeId == id);

            EmployeeUpdateDto updateDto = mapper.Map<EmployeeUpdateDto>(calisan);
            return View(updateDto);
        }
        [HttpPost]
        public IActionResult Update(EmployeeUpdateDto input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }
            Employee gelen = mapper.Map<Employee>(input);
            context.Employees.Update(gelen);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {

            EmployeeCreateDto createDto = new();

            return View(createDto);
        }


        [HttpPost]
        public IActionResult Create(EmployeeCreateDto input)
        {

           if (ModelState.IsValid)
            {
                Employee emp = mapper.Map<Employee>(input);
                //emp.FirstName = input.FirstName;
                //emp.LastName = input.LastName;
                //emp.Title = input.Title;
                //emp.Country = input.Country;
                //emp.City = input.City;
                //emp.HireDate = input.HireDate;
                //emp.HomePhone = input.HomePhone;
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(input);
        }

    }
}
