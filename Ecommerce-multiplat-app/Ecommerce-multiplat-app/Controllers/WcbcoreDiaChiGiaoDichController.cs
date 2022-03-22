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
    public class WcbcoreDiaChiGiaoDichController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreDiaChiGiaoDichController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreDiaChiGiaoDich
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreDiaChiGiaoDich>>> GetWcbcoreDiaChiGiaoDiches()
        {
            return await _context.WcbcoreDiaChiGiaoDiches.ToListAsync();
        }

        // GET: api/WcbcoreDiaChiGiaoDich/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreDiaChiGiaoDich>> GetWcbcoreDiaChiGiaoDich(Guid id)
        {
            var wcbcoreDiaChiGiaoDich = await _context.WcbcoreDiaChiGiaoDiches.FindAsync(id);

            if (wcbcoreDiaChiGiaoDich == null)
            {
                return NotFound();
            }

            return wcbcoreDiaChiGiaoDich;
        }

        // PUT: api/WcbcoreDiaChiGiaoDich/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreDiaChiGiaoDich(Guid id, WcbcoreDiaChiGiaoDich wcbcoreDiaChiGiaoDich)
        {
            if (id != wcbcoreDiaChiGiaoDich.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreDiaChiGiaoDich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreDiaChiGiaoDichExists(id))
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

        // POST: api/WcbcoreDiaChiGiaoDich
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreDiaChiGiaoDich>> PostWcbcoreDiaChiGiaoDich(WcbcoreDiaChiGiaoDich wcbcoreDiaChiGiaoDich)
        {
            _context.WcbcoreDiaChiGiaoDiches.Add(wcbcoreDiaChiGiaoDich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreDiaChiGiaoDichExists(wcbcoreDiaChiGiaoDich.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreDiaChiGiaoDich", new { id = wcbcoreDiaChiGiaoDich.Id }, wcbcoreDiaChiGiaoDich);
        }

        // DELETE: api/WcbcoreDiaChiGiaoDich/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreDiaChiGiaoDich(Guid id)
        {
            var wcbcoreDiaChiGiaoDich = await _context.WcbcoreDiaChiGiaoDiches.FindAsync(id);
            if (wcbcoreDiaChiGiaoDich == null)
            {
                return NotFound();
            }

            _context.WcbcoreDiaChiGiaoDiches.Remove(wcbcoreDiaChiGiaoDich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreDiaChiGiaoDichExists(Guid id)
        {
            return _context.WcbcoreDiaChiGiaoDiches.Any(e => e.Id == id);
        }
    }
}
