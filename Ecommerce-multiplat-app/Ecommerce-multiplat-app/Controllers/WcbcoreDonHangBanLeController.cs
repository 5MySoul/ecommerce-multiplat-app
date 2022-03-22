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
    public class WcbcoreDonHangBanLeController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreDonHangBanLeController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreDonHangBanLe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreDonHangBanLe>>> GetWcbcoreDonHangBanLes()
        {
            return await _context.WcbcoreDonHangBanLes.ToListAsync();
        }

        // GET: api/WcbcoreDonHangBanLe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreDonHangBanLe>> GetWcbcoreDonHangBanLe(Guid id)
        {
            var wcbcoreDonHangBanLe = await _context.WcbcoreDonHangBanLes.FindAsync(id);

            if (wcbcoreDonHangBanLe == null)
            {
                return NotFound();
            }

            return wcbcoreDonHangBanLe;
        }

        // PUT: api/WcbcoreDonHangBanLe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreDonHangBanLe(Guid id, WcbcoreDonHangBanLe wcbcoreDonHangBanLe)
        {
            if (id != wcbcoreDonHangBanLe.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreDonHangBanLe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreDonHangBanLeExists(id))
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

        // POST: api/WcbcoreDonHangBanLe
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreDonHangBanLe>> PostWcbcoreDonHangBanLe(WcbcoreDonHangBanLe wcbcoreDonHangBanLe)
        {
            _context.WcbcoreDonHangBanLes.Add(wcbcoreDonHangBanLe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreDonHangBanLeExists(wcbcoreDonHangBanLe.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreDonHangBanLe", new { id = wcbcoreDonHangBanLe.Id }, wcbcoreDonHangBanLe);
        }

        // DELETE: api/WcbcoreDonHangBanLe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreDonHangBanLe(Guid id)
        {
            var wcbcoreDonHangBanLe = await _context.WcbcoreDonHangBanLes.FindAsync(id);
            if (wcbcoreDonHangBanLe == null)
            {
                return NotFound();
            }

            _context.WcbcoreDonHangBanLes.Remove(wcbcoreDonHangBanLe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreDonHangBanLeExists(Guid id)
        {
            return _context.WcbcoreDonHangBanLes.Any(e => e.Id == id);
        }
    }
}
