using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCOne.Models;

namespace WebAppMVCOne.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,Name="Sam",Designation="Manager",Salary=98000.75,Doj = new DateTime(day:25,month:1,year:2022)
                },
                new Employee()
                {
                    ID = 2,Name="Nitesh",Designation="Developer",Salary=75000.75,Doj = new DateTime(day:20,month:10,year:2012)
                },
                new Employee()
                {
                    ID = 3,Name="Rupesh",Designation="Developer",Salary=89000.75,Doj = new DateTime(day:28,month:03,year:2019)
                },
                new Employee()
                {
                    ID = 4,Name="Gauri",Designation="HR",Salary=58000.75,Doj = new DateTime(day:30,month:12,year:2013)
                },
                new Employee()
                {
                    ID = 5,Name="Babita",Designation="Tester",Salary=45000.75,Doj = new DateTime(day:24,month:01,year:2022)
                },
            };
            return View(listEmployees);

        }
    }
}