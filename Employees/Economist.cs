using System;

namespace EmployeeAdministration.Employees;

public class Economist : IEmployee
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; } = 50000;
    public EmployeeFactory.Roles Role { get; set; } = EmployeeFactory.Roles.Economist;

    public int CompareTo(IEmployee? other)
    {
        return this.Salary.CompareTo(other?.Salary);
    }
}

