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
    public class WcbcoreHangSanXuatController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreHangSanXuatController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreHangSanXuat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreHangSanXuat>>> GetWcbcoreHangSanXuats()
        {
            return await _context.WcbcoreHangSanXuats.ToListAsync();
        }

        // GET: api/WcbcoreHangSanXuat/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreHangSanXuat>> GetWcbcoreHangSanXuat(Guid id)
        {
            var wcbcoreHangSanXuat = await _context.WcbcoreHangSanXuats.FindAsync(id);

            if (wcbcoreHangSanXuat == null)
            {
                return NotFound();
            }

            return wcbcoreHangSanXuat;
        }

        // PUT: api/WcbcoreHangSanXuat/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreHangSanXuat(Guid id, WcbcoreHangSanXuat wcbcoreHangSanXuat)
        {
            if (id != wcbcoreHangSanXuat.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreHangSanXuat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreHangSanXuatExists(id))
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

        // POST: api/WcbcoreHangSanXuat
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreHangSanXuat>> PostWcbcoreHangSanXuat(WcbcoreHangSanXuat wcbcoreHangSanXuat)
        {
            _context.WcbcoreHangSanXuats.Add(wcbcoreHangSanXuat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreHangSanXuatExists(wcbcoreHangSanXuat.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreHangSanXuat", new { id = wcbcoreHangSanXuat.Id }, wcbcoreHangSanXuat);
        }

        // DELETE: api/WcbcoreHangSanXuat/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreHangSanXuat(Guid id)
        {
            var wcbcoreHangSanXuat = await _context.WcbcoreHangSanXuats.FindAsync(id);
            if (wcbcoreHangSanXuat == null)
            {
                return NotFound();
            }

            _context.WcbcoreHangSanXuats.Remove(wcbcoreHangSanXuat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreHangSanXuatExists(Guid id)
        {
            return _context.WcbcoreHangSanXuats.Any(e => e.Id == id);
        }
    }
}
