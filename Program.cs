using EmployeeAdministration.Employees;
using System.Collections.Immutable;
using System.Linq;
namespace EmployeeAdministration;

public class Program
{
    static void Main(string[] args)
    {
        List<IEmployee> Employees = new List<IEmployee>
        {
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Developer, "Anna", "Andersson", 34),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Administrator, "Kalle", "Kallesson", 59),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Boss, "Bosse", "Didriksson", 64),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Economist, "Erika", "Eriksson", 21),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Developer, "Malin", "Karlsson", 45),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Administrator, "Arvid", "Arvidsson", 65),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Boss, "Helen", "Friberg", 23),
            EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Economist, "Lollo", "Is", 19)
        };

        Console.WriteLine("Employees of the company: ");
        foreach (IEmployee employee in Employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} is {employee.Age} years old and works as a {employee.Role}. Salary {employee.Salary}");
        }

        IEnumerable<string> roles = Employees
            .GroupBy(emp => emp.Role)
            .Select(group => group.First())
            .OrderBy(emp => emp.Salary)
            .Select(emp => $"Roll: {emp.Role}, Salary: {emp.Salary}");

        Console.WriteLine("Roles sorted by salary :");
        foreach (string role in roles)
        {
            Console.WriteLine(role);
        }
        Console.WriteLine($"Total salaries for current employees: {Employees.Sum(e => e.Salary)}");
    }
}
