using System;
using static EmployeeAdministration.Employees.EmployeeFactory;

namespace EmployeeAdministration.Employees;

public interface IEmployee
{
    string FirstName { get; set; }
    string LastName { get; set; }

    int Age { get; set; }
    decimal Salary { get; set; }

    Roles Role { get; set; }
}
