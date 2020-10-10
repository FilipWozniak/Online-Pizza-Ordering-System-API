using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOnlineOrderingSystem.Models;

namespace PizzaOnlineOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly s16983Context _context;
        public CustomersController(s16983Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_context.Customer.ToList());
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetCustomer(int ID)
        {
            var customer = _context.Customer.FirstOrDefault(c => c.CustomerId == ID);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Create(Customer newCustomer)
        {
            _context.Customer.Add(newCustomer);
            _context.SaveChanges();

            return StatusCode(201, newCustomer);
        }

        [HttpPut("{CustomerID:int}")]
        public IActionResult Update(int CustomerID, Customer updatedCustomer)
        {
            if (_context.Customer.Count(c => c.CustomerId == CustomerID) == 0)
            {
                return NotFound();
            }

            _context.Customer.Attach(updatedCustomer);
            _context.Entry(updatedCustomer).State = EntityState.Modified;
            _context.SaveChanges();
            
            return Ok(updatedCustomer);
        }

        [HttpDelete("{CustomerID:int}")]
        public IActionResult Delete(int CustomerID)
        {
            var customer = _context.Customer.FirstOrDefault(c => c.CustomerId == CustomerID);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customer);
            _context.SaveChanges();

            return Ok(customer);
        }

    }
}