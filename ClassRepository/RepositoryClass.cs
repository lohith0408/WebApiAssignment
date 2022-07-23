using ClassRepository.Interface;
using ClassRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository
{
   public class RepositoryClass: IRepository
    {
        private readonly NextTurnDBContext _myContext;

        public RepositoryClass(NextTurnDBContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _myContext.Employees.ToListAsync();
        }

        public async Task<Employee> InsertEmployee(Employee emp)
        {
            var result = await _myContext.Employees.AddAsync(emp);
            await _myContext.SaveChangesAsync();
            return result.Entity;
        }
        public Employee Delete(int EmpId)
        {
            var cus = _myContext.Employees.Where(x => x.EmpId == EmpId).SingleOrDefault();
            var result = _myContext.Employees.Remove(cus);
            _myContext.SaveChanges();
            return result.Entity;
        }
        //Edit
        public Employee FindEmployee(int EmpId)
        {
            var cus = _myContext.Employees.Where(x => x.EmpId == EmpId).SingleOrDefault();


            return cus;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            var student = _myContext.Employees.Where(s => s.EmpId == emp.EmpId).FirstOrDefault();
            _myContext.Employees.Remove(student);
            var result = _myContext.Employees.Update(emp);
            /*  student.DeptId = trn.DeptId;
              student.Name = trn.Name;
              student.Email = trn.Email;
              student.Mobile = trn.Mobile;
              student.DeptId = trn.DeptId;*/
            _myContext.SaveChanges();

            return null;
        }





    }
}
