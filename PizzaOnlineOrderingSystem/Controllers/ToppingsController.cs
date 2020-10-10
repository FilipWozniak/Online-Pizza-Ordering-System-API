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
    public class ToppingsController : ControllerBase
    {
        private readonly s16983Context _context;
        public ToppingsController(s16983Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetToppings()
        {
            return Ok(_context.Topping.ToList());
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetTopping(int ID)
        {
            var topping = _context.Topping.FirstOrDefault(t => t.ToppingId == ID);
            if (topping == null)
            {
                return NotFound();
            }

            return Ok(topping);
        }

        [HttpPost]
        public IActionResult Create(Topping newTopping)
        {
            _context.Topping.Add(newTopping);
            _context.SaveChanges();

            return StatusCode(201, newTopping);
        }

        [HttpPut("{TopingID:int}")]
        public IActionResult Update(int ToppingID, Topping updatedTopping)
        {
            if (_context.Topping.Count(t => t.ToppingId == ToppingID) == 0)
            {
                return NotFound();
            }

            _context.Topping.Attach(updatedTopping);
            _context.Entry(updatedTopping).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(updatedTopping);
        }

        [HttpDelete("{ToppingID:int}")]
        public IActionResult Delete(int ToppingID)
        {
            var topping = _context.Topping.FirstOrDefault(t => t.ToppingId == ToppingID);
            if (topping == null)
            {
                return NotFound();
            }

            _context.Topping.Remove(topping);
            _context.SaveChanges();

            return Ok(topping);
        }
    }
}