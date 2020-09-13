using System;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class HomeController
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Index()
        {
            return _employeeRepository.GetEmployee(1);
        }
    }
}
