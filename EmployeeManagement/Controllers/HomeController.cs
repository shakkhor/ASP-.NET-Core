using System;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Index()
        {
            return _employeeRepository.GetEmployeeById(1);
        }

        public ViewResult ViewDataDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(2);
            ViewData["Employee"] = employee;
            ViewData["PageTitle"] = "Employee Details";
            return View(employee);
        }

        public ViewResult ViewBagDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(2);
            ViewBag.Employee = employee;
            ViewBag.PageTitle = "Employee Details";
            return View(employee);
        }

        public ViewResult StronglyTypedDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(2);
            ViewBag.Employee = employee;
            ViewBag.PageTitle = "Employee Details";
            return View(employee);
        }

    }
}
