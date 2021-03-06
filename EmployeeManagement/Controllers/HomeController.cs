﻿using System;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult ViewDataDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(1);
            ViewData["Employee"] = employee;
            ViewData["PageTitle"] = "Employee Details";
            return View();
        }

        public ViewResult ViewBagDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(2);
            ViewBag.Employee = employee;
            ViewBag.PageTitle = "Employee Details";
            return View();
        }

        public ViewResult StronglyTypedDetails()
        {
            Employee employee = _employeeRepository.GetEmployeeById(3);
            var viewModel = new HomeDetailsVeiwModel
            {
                Employee = employee,
                Title = "Employee Detaisl"
            };
            return View(viewModel);
        }

    }
}
