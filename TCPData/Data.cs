using TCPData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee { 
            Id= 1,
            FirstName= "User1",
            LastName= "Blose",
            AnnualSalary=2000.09m,
            IsManager= true,
            DepartmentId= 1
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 2,
                FirstName = "User2",
                LastName = "Frannk",
                AnnualSalary = 6000.04m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 3,
                FirstName = "User3",
                LastName = "Jojo",
                AnnualSalary = 8000.08m,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 4,
                FirstName = "User4",
                LastName = "Roberts",
                AnnualSalary = 4000.03m,
                IsManager = true,
                DepartmentId = 3
            };

            employees.Add(employee);

            return employees; 
        }


        public static List<Department> GetDepartments()
        {
            List<Department> departmets = new List<Department>();

            Department department = new Department {

                ID = 1,
                ShortName = "HR",
                LongName= "Human Resources"
            
            };
            departmets.Add(department);

             department = new Department
            {

                ID = 2,
                ShortName = "FN",
                LongName = "Finance"

            };
            departmets.Add(department);

             department = new Department
            {

                ID = 3,
                ShortName = "TE",
                LongName = "Technology"

            };
            departmets.Add(department);


            return departmets;
        }
    }
}
