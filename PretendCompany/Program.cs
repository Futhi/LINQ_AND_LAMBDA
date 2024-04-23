using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtensions;

namespace PretendCompany
{
public class Program
{
    public static void Main(string[] args)
    {

        //List<Employee> employeeList= Data.GetEmployees();

        //var filteredEmployess = employeeList.Filter(emp => emp.AnnualSalary < 5000);

        //foreach (var employee in filteredEmployess)
        //{
        //    Console.WriteLine($"First Name: {employee.FirstName}");
        //    Console.WriteLine($"Last Name: {employee.LastName}");
        //    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
        //    Console.WriteLine($"Manager: {employee.IsManager}");
        //    Console.WriteLine();
        //}

            //List<Department> departmentList = Data.GetDepartments();

            //var filteredDepartments = departmentList.Where( dept => dept.ShortName == "TE");

            //foreach (var department in filteredDepartments)
            //{
            //    Console.WriteLine($"Id: { department.ID}");
            //    Console.WriteLine($"Short Name: {department.ShortName}");
            //    Console.WriteLine($"Long Name: {department.LongName}");
            //    Console.WriteLine();
            //}

            List<Employee> employeeList = Data.GetEmployees();    
            List<Department> departmentList = Data.GetDepartments();

            var resultList = from emp in employeeList
                             join dept in departmentList
                             on emp.DepartmentId equals dept.ID
                             select new { 
                                 FirstName = emp.FirstName ,
                                 LastName = emp.LastName ,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName
                             };

            foreach (var row in resultList)
            {
                Console.WriteLine($"First Name: {row.FirstName}");
                Console.WriteLine($"Last Name: {row.LastName}");
                Console.WriteLine($"Annual Salary: {row.AnnualSalary}");
                Console.WriteLine($"Manager: {row.Manager}");
                Console.WriteLine($"Department: {row.Department}");
                Console.WriteLine();
            }

            var avearageAnnualSalary = resultList.Average(x => x.AnnualSalary);
            var highestAnnualSalary = resultList.Max(x => x.AnnualSalary);
            var lowestAnnualSalary = resultList.Min(x => x.AnnualSalary);

            Console.WriteLine($"Average Salary: {avearageAnnualSalary}");
            Console.WriteLine($"Highest Salary: {highestAnnualSalary}");
            Console.WriteLine($"Lowest Salary: {lowestAnnualSalary}");





            Console.ReadKey();
    }
}
}

