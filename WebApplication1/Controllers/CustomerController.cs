using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EFModels;
using WebApplication1.EFPersistanceLayer;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            bool isSuccess = EFCustomerContext.create(customer);
            if(isSuccess)
            {
                return RedirectToAction("List");
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Customer> customers = EFCustomerContext.GetCustomers();
            return View(customers);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            bool isSuccess = EFCustomerContext.UpdateCustomer(customer);
            if (isSuccess)
            {
                return RedirectToAction("List");
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            bool isSuccess = EFCustomerContext.Delete(customer.Id);
            if(isSuccess)
            {
                return RedirectToAction("List");
            }
            return View(customer);


        }
    }

}
