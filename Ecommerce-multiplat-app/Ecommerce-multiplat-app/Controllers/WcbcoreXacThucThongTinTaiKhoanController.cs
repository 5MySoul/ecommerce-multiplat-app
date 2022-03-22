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
    public class WcbcoreXacThucThongTinTaiKhoanController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreXacThucThongTinTaiKhoanController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreXacThucThongTinTaiKhoan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreXacThucThongTinTaiKhoan>>> GetWcbcoreXacThucThongTinTaiKhoans()
        {
            return await _context.WcbcoreXacThucThongTinTaiKhoans.ToListAsync();
        }

        // GET: api/WcbcoreXacThucThongTinTaiKhoan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreXacThucThongTinTaiKhoan>> GetWcbcoreXacThucThongTinTaiKhoan(Guid id)
        {
            var wcbcoreXacThucThongTinTaiKhoan = await _context.WcbcoreXacThucThongTinTaiKhoans.FindAsync(id);

            if (wcbcoreXacThucThongTinTaiKhoan == null)
            {
                return NotFound();
            }

            return wcbcoreXacThucThongTinTaiKhoan;
        }

        // PUT: api/WcbcoreXacThucThongTinTaiKhoan/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreXacThucThongTinTaiKhoan(Guid id, WcbcoreXacThucThongTinTaiKhoan wcbcoreXacThucThongTinTaiKhoan)
        {
            if (id != wcbcoreXacThucThongTinTaiKhoan.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreXacThucThongTinTaiKhoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreXacThucThongTinTaiKhoanExists(id))
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

        // POST: api/WcbcoreXacThucThongTinTaiKhoan
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreXacThucThongTinTaiKhoan>> PostWcbcoreXacThucThongTinTaiKhoan(WcbcoreXacThucThongTinTaiKhoan wcbcoreXacThucThongTinTaiKhoan)
        {
            _context.WcbcoreXacThucThongTinTaiKhoans.Add(wcbcoreXacThucThongTinTaiKhoan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreXacThucThongTinTaiKhoanExists(wcbcoreXacThucThongTinTaiKhoan.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreXacThucThongTinTaiKhoan", new { id = wcbcoreXacThucThongTinTaiKhoan.Id }, wcbcoreXacThucThongTinTaiKhoan);
        }

        // DELETE: api/WcbcoreXacThucThongTinTaiKhoan/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreXacThucThongTinTaiKhoan(Guid id)
        {
            var wcbcoreXacThucThongTinTaiKhoan = await _context.WcbcoreXacThucThongTinTaiKhoans.FindAsync(id);
            if (wcbcoreXacThucThongTinTaiKhoan == null)
            {
                return NotFound();
            }

            _context.WcbcoreXacThucThongTinTaiKhoans.Remove(wcbcoreXacThucThongTinTaiKhoan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreXacThucThongTinTaiKhoanExists(Guid id)
        {
            return _context.WcbcoreXacThucThongTinTaiKhoans.Any(e => e.Id == id);
        }
    }
}
