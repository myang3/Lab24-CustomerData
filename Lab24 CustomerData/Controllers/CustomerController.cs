using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab24_CustomerData.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities dbcontext;

        public CustomerController()
        {
            dbcontext = new NorthwindEntities();
        }

        // GET: Customer
        public ActionResult Index()
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            List<Customers> customers = dbcontext.Customers.ToList();
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(string id)
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            Customers customer = dbcontext.Customers.Find(id);

            if (customer == null)
            {
                return View("NotFound");
            }

            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Add()
        {
            var customer = new Customers();
            return View(customer);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Customers customer)
        {  
            try
            {
                // TODO: Add insert logic here
                dbcontext.Customers.Add(customer);
                dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Modify(string id)
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            Customers customer = dbcontext.Customers.Find(id);

            if (customer == null)
            {
                return View("NotFound");
            }

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Modify(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                NorthwindEntities dbcontext = new NorthwindEntities();
                Customers customer = dbcontext.Customers.Find(id);

                customer.CompanyName = collection["CompanyName"].ToString();
                dbcontext.SaveChanges();

                customer.ContactName = collection["ContactName"].ToString();
                dbcontext.SaveChanges();

                customer.ContactTitle = collection["ContactTitle"].ToString();
                dbcontext.SaveChanges();

                customer.Address = collection["Address"].ToString();
                dbcontext.SaveChanges();

                customer.City = collection["City"].ToString();
                dbcontext.SaveChanges();

                customer.Region = collection["Region"].ToString();
                dbcontext.SaveChanges();

                customer.PostalCode = collection["PostalCode"].ToString();
                dbcontext.SaveChanges();

                customer.Country = collection["Country"].ToString();
                dbcontext.SaveChanges();

                customer.Phone = collection["Phone"].ToString();
                dbcontext.SaveChanges();

                customer.Fax = collection["Fax"].ToString();
                dbcontext.SaveChanges();

                return RedirectToAction("Index", collection);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(string id)
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            Customers customer = dbcontext.Customers.Find(id);
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                NorthwindEntities dbcontext = new NorthwindEntities();
                Customers customer = dbcontext.Customers.Find(id);
                dbcontext.Customers.Remove(customer);
                dbcontext.SaveChanges();

                return RedirectToAction("Index", collection);
            }
            catch
            {
                return View();
            }
        }
    }
}
