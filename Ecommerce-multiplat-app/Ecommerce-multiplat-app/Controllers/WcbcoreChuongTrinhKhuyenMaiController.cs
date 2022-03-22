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
    public class WcbcoreChuongTrinhKhuyenMaiController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreChuongTrinhKhuyenMaiController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreChuongTrinhKhuyenMai
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreChuongTrinhKhuyenMai>>> GetWcbcoreChuongTrinhKhuyenMais()
        {
            return await _context.WcbcoreChuongTrinhKhuyenMais.ToListAsync();
        }

        // GET: api/WcbcoreChuongTrinhKhuyenMai/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreChuongTrinhKhuyenMai>> GetWcbcoreChuongTrinhKhuyenMai(Guid id)
        {
            var wcbcoreChuongTrinhKhuyenMai = await _context.WcbcoreChuongTrinhKhuyenMais.FindAsync(id);

            if (wcbcoreChuongTrinhKhuyenMai == null)
            {
                return NotFound();
            }

            return wcbcoreChuongTrinhKhuyenMai;
        }

        // PUT: api/WcbcoreChuongTrinhKhuyenMai/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreChuongTrinhKhuyenMai(Guid id, WcbcoreChuongTrinhKhuyenMai wcbcoreChuongTrinhKhuyenMai)
        {
            if (id != wcbcoreChuongTrinhKhuyenMai.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreChuongTrinhKhuyenMai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreChuongTrinhKhuyenMaiExists(id))
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

        // POST: api/WcbcoreChuongTrinhKhuyenMai
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreChuongTrinhKhuyenMai>> PostWcbcoreChuongTrinhKhuyenMai(WcbcoreChuongTrinhKhuyenMai wcbcoreChuongTrinhKhuyenMai)
        {
            _context.WcbcoreChuongTrinhKhuyenMais.Add(wcbcoreChuongTrinhKhuyenMai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreChuongTrinhKhuyenMaiExists(wcbcoreChuongTrinhKhuyenMai.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreChuongTrinhKhuyenMai", new { id = wcbcoreChuongTrinhKhuyenMai.Id }, wcbcoreChuongTrinhKhuyenMai);
        }

        // DELETE: api/WcbcoreChuongTrinhKhuyenMai/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreChuongTrinhKhuyenMai(Guid id)
        {
            var wcbcoreChuongTrinhKhuyenMai = await _context.WcbcoreChuongTrinhKhuyenMais.FindAsync(id);
            if (wcbcoreChuongTrinhKhuyenMai == null)
            {
                return NotFound();
            }

            _context.WcbcoreChuongTrinhKhuyenMais.Remove(wcbcoreChuongTrinhKhuyenMai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreChuongTrinhKhuyenMaiExists(Guid id)
        {
            return _context.WcbcoreChuongTrinhKhuyenMais.Any(e => e.Id == id);
        }
    }
}
