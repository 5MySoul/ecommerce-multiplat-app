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
    public class WcbcorePhuongThucVanChuyenController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcorePhuongThucVanChuyenController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcorePhuongThucVanChuyen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcorePhuongThucVanChuyen>>> GetWcbcorePhuongThucVanChuyens()
        {
            return await _context.WcbcorePhuongThucVanChuyens.ToListAsync();
        }

        // GET: api/WcbcorePhuongThucVanChuyen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcorePhuongThucVanChuyen>> GetWcbcorePhuongThucVanChuyen(Guid id)
        {
            var wcbcorePhuongThucVanChuyen = await _context.WcbcorePhuongThucVanChuyens.FindAsync(id);

            if (wcbcorePhuongThucVanChuyen == null)
            {
                return NotFound();
            }

            return wcbcorePhuongThucVanChuyen;
        }

        // PUT: api/WcbcorePhuongThucVanChuyen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcorePhuongThucVanChuyen(Guid id, WcbcorePhuongThucVanChuyen wcbcorePhuongThucVanChuyen)
        {
            if (id != wcbcorePhuongThucVanChuyen.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcorePhuongThucVanChuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcorePhuongThucVanChuyenExists(id))
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

        // POST: api/WcbcorePhuongThucVanChuyen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcorePhuongThucVanChuyen>> PostWcbcorePhuongThucVanChuyen(WcbcorePhuongThucVanChuyen wcbcorePhuongThucVanChuyen)
        {
            _context.WcbcorePhuongThucVanChuyens.Add(wcbcorePhuongThucVanChuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcorePhuongThucVanChuyenExists(wcbcorePhuongThucVanChuyen.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcorePhuongThucVanChuyen", new { id = wcbcorePhuongThucVanChuyen.Id }, wcbcorePhuongThucVanChuyen);
        }

        // DELETE: api/WcbcorePhuongThucVanChuyen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcorePhuongThucVanChuyen(Guid id)
        {
            var wcbcorePhuongThucVanChuyen = await _context.WcbcorePhuongThucVanChuyens.FindAsync(id);
            if (wcbcorePhuongThucVanChuyen == null)
            {
                return NotFound();
            }

            _context.WcbcorePhuongThucVanChuyens.Remove(wcbcorePhuongThucVanChuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcorePhuongThucVanChuyenExists(Guid id)
        {
            return _context.WcbcorePhuongThucVanChuyens.Any(e => e.Id == id);
        }
    }
}
