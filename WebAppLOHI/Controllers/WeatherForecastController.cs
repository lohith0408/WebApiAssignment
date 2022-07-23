using BusinessClass.Interface;
using ClassModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLOHI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IBusiness _empBusiness;
        public WeatherForecastController(IBusiness empBusiness)
        {
            _empBusiness = empBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _empBusiness.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeVM obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _empBusiness.InsertEmployee(obj);
            return Ok(result);
        }
        [HttpDelete("{EmpId}")]
        public IActionResult Delete(int EmpId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var res = _empBusiness.Delete(EmpId);
            return Ok(res);
        }
        [HttpPut]

        public IActionResult Edit(EmployeeVM emp)
        {

            var res = _empBusiness.UpdateEmployee(emp);
            return Ok(res);
        }





    }
}


