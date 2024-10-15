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
    public class TripPaymentController : ControllerBase
    {
        private readonly TripPaymentContext _context;

        public TripPaymentController(TripPaymentContext context)
        {
            _context = context;
        }

        // GET: api/TripPayment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripPayment>>> GetTripPayments()
        {
            return await _context.TripPayments.ToListAsync();
        }

        // GET: api/TripPayment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripPayment>> GetTripPayment(int id)
        {
            var tripPayment = await _context.TripPayments.FindAsync(id);

            if (tripPayment == null)
            {
                return NotFound();
            }

            return tripPayment;
        }

        // PUT: api/TripPayment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTripPayment(int id, TripPayment tripPayment)
        {
            if (id != tripPayment.TripPaymentId)
            {
                return BadRequest();
            }

            _context.Entry(tripPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TripPaymentExists(id))
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

        // POST: api/TripPayment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TripPayment>> PostTripPayment(TripPayment tripPayment)
        {
            _context.TripPayments.Add(tripPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTripPayment", new { id = tripPayment.TripPaymentId }, tripPayment);
        }

        // DELETE: api/TripPayment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTripPayment(int id)
        {
            var tripPayment = await _context.TripPayments.FindAsync(id);
            if (tripPayment == null)
            {
                return NotFound();
            }

            _context.TripPayments.Remove(tripPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TripPaymentExists(int id)
        {
            return _context.TripPayments.Any(e => e.TripPaymentId == id);
        }
    }
}
