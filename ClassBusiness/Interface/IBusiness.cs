using ClassModels;
using ClassRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass.Interface
{
     public interface IBusiness
    {
        Task<List<EmployeeVM>> GetAllEmployees();
        Task<EmployeeVM> InsertEmployee(EmployeeVM emp);
        EmployeeVM Delete(int EmpId);
        EmployeeVM FindEmployee(int EmpId);

        EmployeeVM UpdateEmployee(EmployeeVM emp);
    }
}
