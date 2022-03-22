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
    public class WcbcoreNhomSanPhamController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreNhomSanPhamController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreNhomSanPham
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreNhomSanPham>>> GetWcbcoreNhomSanPhams()
        {
            return await _context.WcbcoreNhomSanPhams.ToListAsync();
        }

        // GET: api/WcbcoreNhomSanPham/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreNhomSanPham>> GetWcbcoreNhomSanPham(Guid id)
        {
            var wcbcoreNhomSanPham = await _context.WcbcoreNhomSanPhams.FindAsync(id);

            if (wcbcoreNhomSanPham == null)
            {
                return NotFound();
            }

            return wcbcoreNhomSanPham;
        }

        // PUT: api/WcbcoreNhomSanPham/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreNhomSanPham(Guid id, WcbcoreNhomSanPham wcbcoreNhomSanPham)
        {
            if (id != wcbcoreNhomSanPham.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreNhomSanPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreNhomSanPhamExists(id))
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

        // POST: api/WcbcoreNhomSanPham
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreNhomSanPham>> PostWcbcoreNhomSanPham(WcbcoreNhomSanPham wcbcoreNhomSanPham)
        {
            _context.WcbcoreNhomSanPhams.Add(wcbcoreNhomSanPham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreNhomSanPhamExists(wcbcoreNhomSanPham.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreNhomSanPham", new { id = wcbcoreNhomSanPham.Id }, wcbcoreNhomSanPham);
        }

        // DELETE: api/WcbcoreNhomSanPham/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreNhomSanPham(Guid id)
        {
            var wcbcoreNhomSanPham = await _context.WcbcoreNhomSanPhams.FindAsync(id);
            if (wcbcoreNhomSanPham == null)
            {
                return NotFound();
            }

            _context.WcbcoreNhomSanPhams.Remove(wcbcoreNhomSanPham);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreNhomSanPhamExists(Guid id)
        {
            return _context.WcbcoreNhomSanPhams.Any(e => e.Id == id);
        }
    }
}
