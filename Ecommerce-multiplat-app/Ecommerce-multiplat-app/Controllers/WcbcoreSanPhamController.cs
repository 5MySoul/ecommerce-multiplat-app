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
    public class WcbcoreSanPhamController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreSanPhamController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreSanPham
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreSanPham>>> GetWcbcoreSanPhams()
        {
            return await _context.WcbcoreSanPhams.ToListAsync();
        }

        // GET: api/WcbcoreSanPham/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreSanPham>> GetWcbcoreSanPham(Guid id)
        {
            var wcbcoreSanPham = await _context.WcbcoreSanPhams.FindAsync(id);

            if (wcbcoreSanPham == null)
            {
                return NotFound();
            }

            return wcbcoreSanPham;
        }

        // PUT: api/WcbcoreSanPham/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreSanPham(Guid id, WcbcoreSanPham wcbcoreSanPham)
        {
            if (id != wcbcoreSanPham.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreSanPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreSanPhamExists(id))
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

        // POST: api/WcbcoreSanPham
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreSanPham>> PostWcbcoreSanPham(WcbcoreSanPham wcbcoreSanPham)
        {
            _context.WcbcoreSanPhams.Add(wcbcoreSanPham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreSanPhamExists(wcbcoreSanPham.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreSanPham", new { id = wcbcoreSanPham.Id }, wcbcoreSanPham);
        }

        // DELETE: api/WcbcoreSanPham/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreSanPham(Guid id)
        {
            var wcbcoreSanPham = await _context.WcbcoreSanPhams.FindAsync(id);
            if (wcbcoreSanPham == null)
            {
                return NotFound();
            }

            _context.WcbcoreSanPhams.Remove(wcbcoreSanPham);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreSanPhamExists(Guid id)
        {
            return _context.WcbcoreSanPhams.Any(e => e.Id == id);
        }
    }
}
