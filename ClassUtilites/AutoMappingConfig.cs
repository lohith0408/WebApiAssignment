using AutoMapper;
using ClassModels;
using ClassRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUtilites
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<Department, DepartmentVM>().ReverseMap();
        }
       
    }
}
