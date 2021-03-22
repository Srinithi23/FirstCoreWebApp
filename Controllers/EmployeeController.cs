using FirstCoreWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebApp.Controllers
{
    public class EmployeeController : Controller
    {

        Employee e = new Employee();
        public static List<Employee> newemp = Employee.getEmployees();
        
        // GET: EmployeeController
        public ActionResult EmployeesDetails()
        {
            return View(newemp);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employeees)
        {
            try
            {
                e.Addemp(employeees);

                return RedirectToAction("EmployeesDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            //  var empp = Employee.where(s => s.EmpId == id).FirstOrDefault();
            Employee data = newemp.FirstOrDefault(x => x.EmpId == id);
            return View(data);
            //return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee empp)
        {
            try
            {
                //var Name = empp.EmpId;
                Employee data = newemp.FirstOrDefault(x => x.EmpId == id);
                data.EmpId = empp.EmpId;
                data.EmpName = empp.EmpName;
                data.Salary = empp.Salary;
                return RedirectToAction("EmployeesDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee data = newemp.FirstOrDefault(x => x.EmpId == id);
            e.DeleteDetails(data);
            
            return View("EmployeesDetails");
        }

        // POST: EmployeeController/Delete/5
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                return RedirectToAction("EmployeesDetails");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
