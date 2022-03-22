#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce_multiplat_app.Models;

namespace Ecommerce_multiplat_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WcbcoreNhomNccController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreNhomNccController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreNhomNcc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreNhomNcc>>> GetWcbcoreNhomNccs()
        {
            return await _context.WcbcoreNhomNccs.ToListAsync();
        }

        // GET: api/WcbcoreNhomNcc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreNhomNcc>> GetWcbcoreNhomNcc(Guid id)
        {
            var wcbcoreNhomNcc = await _context.WcbcoreNhomNccs.FindAsync(id);

            if (wcbcoreNhomNcc == null)
            {
                return NotFound();
            }

            return wcbcoreNhomNcc;
        }

        // PUT: api/WcbcoreNhomNcc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreNhomNcc(Guid id, WcbcoreNhomNcc wcbcoreNhomNcc)
        {
            if (id != wcbcoreNhomNcc.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreNhomNcc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreNhomNccExists(id))
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

        // POST: api/WcbcoreNhomNcc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreNhomNcc>> PostWcbcoreNhomNcc(WcbcoreNhomNcc wcbcoreNhomNcc)
        {
            _context.WcbcoreNhomNccs.Add(wcbcoreNhomNcc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreNhomNccExists(wcbcoreNhomNcc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreNhomNcc", new { id = wcbcoreNhomNcc.Id }, wcbcoreNhomNcc);
        }

        // DELETE: api/WcbcoreNhomNcc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreNhomNcc(Guid id)
        {
            var wcbcoreNhomNcc = await _context.WcbcoreNhomNccs.FindAsync(id);
            if (wcbcoreNhomNcc == null)
            {
                return NotFound();
            }

            _context.WcbcoreNhomNccs.Remove(wcbcoreNhomNcc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreNhomNccExists(Guid id)
        {
            return _context.WcbcoreNhomNccs.Any(e => e.Id == id);
        }
    }
}
