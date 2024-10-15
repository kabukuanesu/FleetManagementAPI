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
    public class GeofenceController : ControllerBase
    {
        private readonly GeofenceContext _context;

        public GeofenceController(GeofenceContext context)
        {
            _context = context;
        }

        // GET: api/Geofence
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Geofence>>> GetGeofences()
        {
            return await _context.Geofences.ToListAsync();
        }

        // GET: api/Geofence/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Geofence>> GetGeofence(int id)
        {
            var geofence = await _context.Geofences.FindAsync(id);

            if (geofence == null)
            {
                return NotFound();
            }

            return geofence;
        }

        // PUT: api/Geofence/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeofence(int id, Geofence geofence)
        {
            if (id != geofence.GeofenceId)
            {
                return BadRequest();
            }

            _context.Entry(geofence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeofenceExists(id))
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

        // POST: api/Geofence
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Geofence>> PostGeofence(Geofence geofence)
        {
            _context.Geofences.Add(geofence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeofence", new { id = geofence.GeofenceId }, geofence);
        }

        // DELETE: api/Geofence/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeofence(int id)
        {
            var geofence = await _context.Geofences.FindAsync(id);
            if (geofence == null)
            {
                return NotFound();
            }

            _context.Geofences.Remove(geofence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeofenceExists(int id)
        {
            return _context.Geofences.Any(e => e.GeofenceId == id);
        }
    }
}
