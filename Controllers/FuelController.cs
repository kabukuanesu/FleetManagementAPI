using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FleetManagementAPI.Models;

namespace FleetManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly FuelContext _context;

        public FuelController(FuelContext context)
        {
            _context = context;
        }

        // GET: api/Fuel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fuel>>> GetFuels()
        {
            return await _context.Fuels.ToListAsync();
        }

        // GET: api/Fuel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fuel>> GetFuel(int id)
        {
            var fuel = await _context.Fuels.FindAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            return fuel;
        }

        // PUT: api/Fuel/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuel(int id, Fuel fuel)
        {
            if (id != fuel.VehicleFuelId)
            {
                return BadRequest();
            }

            _context.Entry(fuel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Fuel
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fuel>> PostFuel(Fuel fuel)
        {
            _context.Fuels.Add(fuel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuel", new { id = fuel.VehicleFuelId }, fuel);
        }

        // DELETE: api/Fuel/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFuel(int id)
        {
            var fuel = await _context.Fuels.FindAsync(id);
            if (fuel == null)
            {
                return NotFound();
            }

            _context.Fuels.Remove(fuel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuelExists(int id)
        {
            return _context.Fuels.Any(e => e.VehicleFuelId == id);
        }
    }
}
