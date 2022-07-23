using ClassRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository.Interface
{
     public interface IRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> InsertEmployee(Employee emp);

        Employee Delete(int EmpId);
        Employee FindEmployee(int EmpId);

        Employee UpdateEmployee(Employee trn);


    }
}
