using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationStoredProcedure1.Controllers
{
    /*public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }*/
    public class HomeController : Controller
{
    // GET: Home
    public ActionResult Index()
    {
        using (TrainingDBEntities entities = new TrainingDBEntities())
        {
            List<Customer> customers = entities.Customers_PerformCRUD("SELECT", null, null, null).ToList();
 
            //Add a Dummy Row.
            customers.Insert(0, new Customer());
            return View(customers.ToList());
        }
    }
 
    [HttpPost]
    public JsonResult InsertCustomer(Customer customer)
    {
        using (TrainingDBEntities entities = new TrainingDBEntities())
        {
            Customer _customer = entities.Customers_PerformCRUD("INSERT", default, customer.Name, customer.Country).FirstOrDefault();
            return Json(_customer);
        }
    }
 
    [HttpPost]
    public ActionResult UpdateCustomer(Customer customer)
    {
        using (TrainingDBEntities entities = new TrainingDBEntities())
        {
            entities.Customers_PerformCRUD("UPDATE", customer.CustomerId, customer.Name, customer.Country);
        }
 
        return new EmptyResult();
    }
 
    [HttpPost]
    public ActionResult DeleteCustomer(int customerId)
    {
        using (TrainingDBEntities entities = new TrainingDBEntities())
        {
            entities.Customers_PerformCRUD("DELETE", customerId, null, null);
        }
 
        return new EmptyResult();
    }
}

}