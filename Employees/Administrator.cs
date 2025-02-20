using System;

namespace EmployeeAdministration.Employees;

public class Administrator : IEmployee
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; } = 30000;
    public EmployeeFactory.Roles Role { get; set; } = EmployeeFactory.Roles.Administrator;
}
