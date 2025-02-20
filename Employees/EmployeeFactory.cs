using System;

namespace EmployeeAdministration.Employees;

public class EmployeeFactory
{
    public enum Roles
    {
        Boss,
        Administrator,
        Economist,
        Developer
    }

    public static readonly Dictionary<Roles, Func<string, string, int, IEmployee>> _factory =
    new Dictionary<Roles, Func<string, string, int, IEmployee>>{
        {Roles.Boss,(FirstName,LastName,Age)=>new Boss{FirstName=FirstName, LastName=LastName, Age=Age}},
        {Roles.Administrator,(FirstName,LastName,Age)=>new Administrator{FirstName=FirstName, LastName=LastName, Age=Age}},
        {Roles.Developer,(FirstName,LastName,Age)=>new Developer{FirstName=FirstName, LastName=LastName, Age=Age}},
        {Roles.Economist,(FirstName,LastName,Age)=>new Economist{FirstName=FirstName, LastName=LastName, Age=Age}},
    };

    public static IEmployee GetNewEmployee(Roles role, string FirstName, string LastName, int Age)
    {
        if (_factory.ContainsKey(role))
        {
            return _factory[role](FirstName, LastName, Age);
        }
        throw new ArgumentException($"{role} is not a valid role");
    }

}
