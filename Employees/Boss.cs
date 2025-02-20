using System;

namespace EmployeeAdministration.Employees;

public class Boss : IEmployee
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; } = 60000;
    public EmployeeFactory.Roles Role { get; set; } = EmployeeFactory.Roles.Boss;
}

