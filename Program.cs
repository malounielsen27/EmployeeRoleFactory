using EmployeeAdministration.Employees;
using System.Linq;
namespace EmployeeAdministration;

public class Program
{
    static void Main(string[] args)
    {
        List<IEmployee> Employees = new List<IEmployee>();
        IEmployee a = EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Developer, "Anna", "Andersson", 34);
        IEmployee b = EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Administrator, "Kalle", "Kallesson", 59);
        IEmployee c = EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Boss, "Bosse", "Didriksson", 64);
        IEmployee d = EmployeeFactory.GetNewEmployee(EmployeeFactory.Roles.Economist, "Erika", "Eriksson", 21);
        Employees.Add(a);
        Employees.Add(b);
        Employees.Add(c);
        Employees.Add(d);


        Console.WriteLine("Employees of the company: ");
        foreach (IEmployee e in Employees)
        {
            Console.WriteLine($"{e.FirstName} {e.LastName} is {e.Age} years old and works as a {e.Role}. Salary {e.Salary}");
        }

        Console.WriteLine($"Total salaries: {Employees.Sum(e => e.Salary)}");
    }
}
