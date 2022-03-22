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
    public class WcbcoreDonViVanChuyensController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreDonViVanChuyensController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreDonViVanChuyens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreDonViVanChuyen>>> GetWcbcoreDonViVanChuyens()
        {
            return await _context.WcbcoreDonViVanChuyens.ToListAsync();
        }

        // GET: api/WcbcoreDonViVanChuyens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreDonViVanChuyen>> GetWcbcoreDonViVanChuyen(Guid id)
        {
            var wcbcoreDonViVanChuyen = await _context.WcbcoreDonViVanChuyens.FindAsync(id);

            if (wcbcoreDonViVanChuyen == null)
            {
                return NotFound();
            }

            return wcbcoreDonViVanChuyen;
        }

        // PUT: api/WcbcoreDonViVanChuyens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreDonViVanChuyen(Guid id, WcbcoreDonViVanChuyen wcbcoreDonViVanChuyen)
        {
            if (id != wcbcoreDonViVanChuyen.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreDonViVanChuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreDonViVanChuyenExists(id))
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

        // POST: api/WcbcoreDonViVanChuyens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreDonViVanChuyen>> PostWcbcoreDonViVanChuyen(WcbcoreDonViVanChuyen wcbcoreDonViVanChuyen)
        {
            _context.WcbcoreDonViVanChuyens.Add(wcbcoreDonViVanChuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreDonViVanChuyenExists(wcbcoreDonViVanChuyen.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreDonViVanChuyen", new { id = wcbcoreDonViVanChuyen.Id }, wcbcoreDonViVanChuyen);
        }

        // DELETE: api/WcbcoreDonViVanChuyens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreDonViVanChuyen(Guid id)
        {
            var wcbcoreDonViVanChuyen = await _context.WcbcoreDonViVanChuyens.FindAsync(id);
            if (wcbcoreDonViVanChuyen == null)
            {
                return NotFound();
            }

            _context.WcbcoreDonViVanChuyens.Remove(wcbcoreDonViVanChuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreDonViVanChuyenExists(Guid id)
        {
            return _context.WcbcoreDonViVanChuyens.Any(e => e.Id == id);
        }
    }
}
