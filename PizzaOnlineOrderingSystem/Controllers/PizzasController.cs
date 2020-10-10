using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOnlineOrderingSystem.Models;

namespace PizzaOnlineOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly s16983Context _context;
        public PizzasController(s16983Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPizzas()
        {
            return Ok(_context.Pizza.ToList());
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetPizza(int ID)
        {
            var pizza = _context.Pizza.FirstOrDefault(p => p.PizzaId == ID);
            if (pizza == null)
            {
                return NotFound();
            }

            return Ok(pizza);
        }

        [HttpPost]
        public IActionResult Create(Pizza newPizza)
        {
            _context.Pizza.Add(newPizza);
            _context.SaveChanges();

            return StatusCode(201, newPizza);
        }

        [HttpPut("{PizzaID:int}")]
        public IActionResult Update(int PizzaID, Pizza updatedPizza)
        {
            if (_context.Pizza.Count(p => p.PizzaId == PizzaID) == 0)
            {
                return NotFound();
            }

            _context.Pizza.Attach(updatedPizza);
            _context.Entry(updatedPizza).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(updatedPizza);
        }

        [HttpDelete("{PizzaID:int}")]
        public IActionResult Delete(int PizzaID)
        {
            var pizza = _context.Pizza.FirstOrDefault(p => p.PizzaId == PizzaID);
            if (pizza == null)
            {
                return NotFound();
            }

            _context.Pizza.Remove(pizza);
            _context.SaveChanges();

            return Ok(pizza);
        }
    }
}