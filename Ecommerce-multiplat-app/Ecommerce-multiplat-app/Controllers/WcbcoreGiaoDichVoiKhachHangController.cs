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
    public class WcbcoreGiaoDichVoiKhachHangController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreGiaoDichVoiKhachHangController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreGiaoDichVoiKhachHang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreGiaoDichVoiKhachHang>>> GetWcbcoreGiaoDichVoiKhachHangs()
        {
            return await _context.WcbcoreGiaoDichVoiKhachHangs.ToListAsync();
        }

        // GET: api/WcbcoreGiaoDichVoiKhachHang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreGiaoDichVoiKhachHang>> GetWcbcoreGiaoDichVoiKhachHang(Guid id)
        {
            var wcbcoreGiaoDichVoiKhachHang = await _context.WcbcoreGiaoDichVoiKhachHangs.FindAsync(id);

            if (wcbcoreGiaoDichVoiKhachHang == null)
            {
                return NotFound();
            }

            return wcbcoreGiaoDichVoiKhachHang;
        }

        // PUT: api/WcbcoreGiaoDichVoiKhachHang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreGiaoDichVoiKhachHang(Guid id, WcbcoreGiaoDichVoiKhachHang wcbcoreGiaoDichVoiKhachHang)
        {
            if (id != wcbcoreGiaoDichVoiKhachHang.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreGiaoDichVoiKhachHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreGiaoDichVoiKhachHangExists(id))
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

        // POST: api/WcbcoreGiaoDichVoiKhachHang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreGiaoDichVoiKhachHang>> PostWcbcoreGiaoDichVoiKhachHang(WcbcoreGiaoDichVoiKhachHang wcbcoreGiaoDichVoiKhachHang)
        {
            _context.WcbcoreGiaoDichVoiKhachHangs.Add(wcbcoreGiaoDichVoiKhachHang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreGiaoDichVoiKhachHangExists(wcbcoreGiaoDichVoiKhachHang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreGiaoDichVoiKhachHang", new { id = wcbcoreGiaoDichVoiKhachHang.Id }, wcbcoreGiaoDichVoiKhachHang);
        }

        // DELETE: api/WcbcoreGiaoDichVoiKhachHang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreGiaoDichVoiKhachHang(Guid id)
        {
            var wcbcoreGiaoDichVoiKhachHang = await _context.WcbcoreGiaoDichVoiKhachHangs.FindAsync(id);
            if (wcbcoreGiaoDichVoiKhachHang == null)
            {
                return NotFound();
            }

            _context.WcbcoreGiaoDichVoiKhachHangs.Remove(wcbcoreGiaoDichVoiKhachHang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreGiaoDichVoiKhachHangExists(Guid id)
        {
            return _context.WcbcoreGiaoDichVoiKhachHangs.Any(e => e.Id == id);
        }
    }
}
