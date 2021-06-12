using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1, Department="HR", Name="John", Email="john@yopmail.com"},
                new Employee(){ Id=2, Department="HR1", Name="John1", Email="john1@yopmail.com"},
                new Employee(){ Id=2, Department="HR2", Name="John2", Email="john2@yopmail.com"}
            };
        }
       
        public Employee GetEmployeeById(int Id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
