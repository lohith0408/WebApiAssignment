using BusinessClass;
using BusinessClass.Interface;
using ClassModels;
using LOHI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LOHI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBusiness _employeeBusiness;

        public HomeController(IBusiness BusinessClass)
        {
            _employeeBusiness = BusinessClass;
        }



        public async Task<IActionResult> Index()
        {

            List<EmployeeVM> employees = await _employeeBusiness.GetAllEmployees();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeVM emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _employeeBusiness.InsertEmployee(emp);
            return View(result);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
