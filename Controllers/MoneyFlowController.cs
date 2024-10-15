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
    public class MoneyFlowController : ControllerBase
    {
        private readonly MoneyFlowContext _context;

        public MoneyFlowController(MoneyFlowContext context)
        {
            _context = context;
        }

        // GET: api/MoneyFlow
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MoneyFlow>>> GetMoneyFlows()
        {
            return await _context.MoneyFlows.ToListAsync();
        }

        // GET: api/MoneyFlow/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MoneyFlow>> GetMoneyFlow(int id)
        {
            var moneyFlow = await _context.MoneyFlows.FindAsync(id);

            if (moneyFlow == null)
            {
                return NotFound();
            }

            return moneyFlow;
        }

        // PUT: api/MoneyFlow/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoneyFlow(int id, MoneyFlow moneyFlow)
        {
            if (id != moneyFlow.MoneyFlowId)
            {
                return BadRequest();
            }

            _context.Entry(moneyFlow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoneyFlowExists(id))
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

        // POST: api/MoneyFlow
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MoneyFlow>> PostMoneyFlow(MoneyFlow moneyFlow)
        {
            _context.MoneyFlows.Add(moneyFlow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoneyFlow", new { id = moneyFlow.MoneyFlowId }, moneyFlow);
        }

        // DELETE: api/MoneyFlow/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoneyFlow(int id)
        {
            var moneyFlow = await _context.MoneyFlows.FindAsync(id);
            if (moneyFlow == null)
            {
                return NotFound();
            }

            _context.MoneyFlows.Remove(moneyFlow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoneyFlowExists(int id)
        {
            return _context.MoneyFlows.Any(e => e.MoneyFlowId == id);
        }
    }
}
