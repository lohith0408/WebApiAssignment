using AutoMapper;
using BusinessClass.Interface;
using ClassRepository.Interface;
using ClassRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace BusinessClass
{
     public class ClassBusiness : IBusiness
    {
        private readonly IRepository _RepositoryClass;
        private readonly IMapper _mapper;
        public ClassBusiness(IRepository RepositoryClass, IMapper mapper)
        {
            _RepositoryClass = RepositoryClass;
            _mapper = mapper;
        }

        public async Task<List<EmployeeVM>> GetAllEmployees()
        {
            List<Employee> list = await _RepositoryClass.GetAllEmployees();
            return _mapper.Map<List<EmployeeVM>>(list);
        }
        public async Task<EmployeeVM> InsertEmployee(EmployeeVM emp)
        {
            var result = await _RepositoryClass.InsertEmployee(_mapper.Map<Employee>(emp));
            return _mapper.Map<EmployeeVM>(result);
        }

        public EmployeeVM Delete(int EmpId)
        {
            var result = _RepositoryClass.Delete(EmpId);
            return _mapper.Map<EmployeeVM>(result);
        }
        public EmployeeVM FindEmployee(int EmpId)
        {
            var result = _RepositoryClass.FindEmployee(EmpId);
            return _mapper.Map<EmployeeVM>(result);
        }

        public EmployeeVM UpdateEmployee(EmployeeVM emp)
        {
            var result = _RepositoryClass.UpdateEmployee(_mapper.Map<Employee>(emp));
            return _mapper.Map<EmployeeVM>(result);

        }






    }
}
