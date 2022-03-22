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
    public class WcbcoreThuocTinhSanPhamController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreThuocTinhSanPhamController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreThuocTinhSanPham
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreThuocTinhSanPham>>> GetWcbcoreThuocTinhSanPhams()
        {
            return await _context.WcbcoreThuocTinhSanPhams.ToListAsync();
        }

        // GET: api/WcbcoreThuocTinhSanPham/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreThuocTinhSanPham>> GetWcbcoreThuocTinhSanPham(Guid id)
        {
            var wcbcoreThuocTinhSanPham = await _context.WcbcoreThuocTinhSanPhams.FindAsync(id);

            if (wcbcoreThuocTinhSanPham == null)
            {
                return NotFound();
            }

            return wcbcoreThuocTinhSanPham;
        }

        // PUT: api/WcbcoreThuocTinhSanPham/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreThuocTinhSanPham(Guid id, WcbcoreThuocTinhSanPham wcbcoreThuocTinhSanPham)
        {
            if (id != wcbcoreThuocTinhSanPham.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreThuocTinhSanPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreThuocTinhSanPhamExists(id))
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

        // POST: api/WcbcoreThuocTinhSanPham
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreThuocTinhSanPham>> PostWcbcoreThuocTinhSanPham(WcbcoreThuocTinhSanPham wcbcoreThuocTinhSanPham)
        {
            _context.WcbcoreThuocTinhSanPhams.Add(wcbcoreThuocTinhSanPham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreThuocTinhSanPhamExists(wcbcoreThuocTinhSanPham.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreThuocTinhSanPham", new { id = wcbcoreThuocTinhSanPham.Id }, wcbcoreThuocTinhSanPham);
        }

        // DELETE: api/WcbcoreThuocTinhSanPham/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreThuocTinhSanPham(Guid id)
        {
            var wcbcoreThuocTinhSanPham = await _context.WcbcoreThuocTinhSanPhams.FindAsync(id);
            if (wcbcoreThuocTinhSanPham == null)
            {
                return NotFound();
            }

            _context.WcbcoreThuocTinhSanPhams.Remove(wcbcoreThuocTinhSanPham);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreThuocTinhSanPhamExists(Guid id)
        {
            return _context.WcbcoreThuocTinhSanPhams.Any(e => e.Id == id);
        }
    }
}
