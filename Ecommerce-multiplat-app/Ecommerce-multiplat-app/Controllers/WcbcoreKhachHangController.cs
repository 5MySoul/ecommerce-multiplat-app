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
    public class WcbcoreKhachHangController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreKhachHangController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreKhachHang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreKhachHang>>> GetWcbcoreKhachHangs()
        {
            return await _context.WcbcoreKhachHangs.ToListAsync();
        }

        // GET: api/WcbcoreKhachHang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreKhachHang>> GetWcbcoreKhachHang(Guid id)
        {
            var wcbcoreKhachHang = await _context.WcbcoreKhachHangs.FindAsync(id);

            if (wcbcoreKhachHang == null)
            {
                return NotFound();
            }

            return wcbcoreKhachHang;
        }

        // PUT: api/WcbcoreKhachHang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreKhachHang(Guid id, WcbcoreKhachHang wcbcoreKhachHang)
        {
            if (id != wcbcoreKhachHang.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreKhachHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreKhachHangExists(id))
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

        // POST: api/WcbcoreKhachHang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreKhachHang>> PostWcbcoreKhachHang(WcbcoreKhachHang wcbcoreKhachHang)
        {
            _context.WcbcoreKhachHangs.Add(wcbcoreKhachHang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreKhachHangExists(wcbcoreKhachHang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreKhachHang", new { id = wcbcoreKhachHang.Id }, wcbcoreKhachHang);
        }

        // DELETE: api/WcbcoreKhachHang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreKhachHang(Guid id)
        {
            var wcbcoreKhachHang = await _context.WcbcoreKhachHangs.FindAsync(id);
            if (wcbcoreKhachHang == null)
            {
                return NotFound();
            }

            _context.WcbcoreKhachHangs.Remove(wcbcoreKhachHang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreKhachHangExists(Guid id)
        {
            return _context.WcbcoreKhachHangs.Any(e => e.Id == id);
        }
    }
}
