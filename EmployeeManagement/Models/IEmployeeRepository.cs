using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int Id);
        IEnumerable<Employee> GetAllEmployees();

    }
}
