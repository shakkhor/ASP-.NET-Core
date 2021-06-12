using System;
namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int Id);
    }
}
