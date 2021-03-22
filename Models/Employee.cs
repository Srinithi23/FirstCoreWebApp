using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }


        public Employee(int eid, string name, float salry)
        {
            EmpId = eid;
            EmpName = name;
            Salary = salry;
        }
        public Employee()
        {

        }
        public static List<Employee> employees = new List<Employee>();

        public static List<Employee> getEmployees()
        {
           // employees.Clear();
            employees.Add(new Employee(1, "Sri", 30000));
            employees.Add(new Employee(2, "Dev", 35000));
            employees.Add(new Employee(3, "Thiya", 38000));
            employees.Add(new Employee(4, "william", 48000));

            return employees;

        }

        public void Addemp(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteDetails(Employee employee)
        {
            employees.Remove(employee);
        }

    }
}
