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
    public class WcbcoreSanPhamKmDhblController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreSanPhamKmDhblController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreSanPhamKmDhbl
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreSanPhamKmDhbl>>> GetWcbcoreSanPhamKmDhbls()
        {
            return await _context.WcbcoreSanPhamKmDhbls.ToListAsync();
        }

        // GET: api/WcbcoreSanPhamKmDhbl/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreSanPhamKmDhbl>> GetWcbcoreSanPhamKmDhbl(Guid id)
        {
            var wcbcoreSanPhamKmDhbl = await _context.WcbcoreSanPhamKmDhbls.FindAsync(id);

            if (wcbcoreSanPhamKmDhbl == null)
            {
                return NotFound();
            }

            return wcbcoreSanPhamKmDhbl;
        }

        // PUT: api/WcbcoreSanPhamKmDhbl/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreSanPhamKmDhbl(Guid id, WcbcoreSanPhamKmDhbl wcbcoreSanPhamKmDhbl)
        {
            if (id != wcbcoreSanPhamKmDhbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreSanPhamKmDhbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreSanPhamKmDhblExists(id))
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

        // POST: api/WcbcoreSanPhamKmDhbl
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreSanPhamKmDhbl>> PostWcbcoreSanPhamKmDhbl(WcbcoreSanPhamKmDhbl wcbcoreSanPhamKmDhbl)
        {
            _context.WcbcoreSanPhamKmDhbls.Add(wcbcoreSanPhamKmDhbl);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreSanPhamKmDhblExists(wcbcoreSanPhamKmDhbl.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreSanPhamKmDhbl", new { id = wcbcoreSanPhamKmDhbl.Id }, wcbcoreSanPhamKmDhbl);
        }

        // DELETE: api/WcbcoreSanPhamKmDhbl/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreSanPhamKmDhbl(Guid id)
        {
            var wcbcoreSanPhamKmDhbl = await _context.WcbcoreSanPhamKmDhbls.FindAsync(id);
            if (wcbcoreSanPhamKmDhbl == null)
            {
                return NotFound();
            }

            _context.WcbcoreSanPhamKmDhbls.Remove(wcbcoreSanPhamKmDhbl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreSanPhamKmDhblExists(Guid id)
        {
            return _context.WcbcoreSanPhamKmDhbls.Any(e => e.Id == id);
        }
    }
}
