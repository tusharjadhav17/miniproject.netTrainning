using MyWebApp.Models;
using MyWebApp.Models.DLA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private object emp_id;

        public EmployeeController()
        {
            this.employeeRepository = new EmployeeRepository(new TrainingDBEntities1());
        }
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

       
        [HttpGet]
        public ActionResult Index()
        {
            var model = employeeRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if(ModelState.IsValid)
            {
                employeeRepository.Insert(model);
                employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View(model);    
        }

        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            Employee model = employeeRepository.GetById(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if(ModelState.IsValid)
            {
                employeeRepository.Update(model);
                employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);  
            }
           
        }
        


        [HttpGet]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee model = employeeRepository.GetById(id);
            return View(model);
        }

       
        [HttpPost, ActionName("DeleteConfirmed")]
        public ActionResult DeleteConfirmed()
        {
            string id = Request.Params["emp_id"];
            var id1 = Request.QueryString["id"];
            var idnew = Convert.ToInt32(id);
            employeeRepository.Delete(idnew);
            employeeRepository.Save();
            return RedirectToAction("index", "Employee");


           
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
            var model = employeeRepository.GetAll();
            return View(model);
           /* EmployeeViewModel model = new EmployeeViewModel();
            return View(model);*/
        }

       

    }
}