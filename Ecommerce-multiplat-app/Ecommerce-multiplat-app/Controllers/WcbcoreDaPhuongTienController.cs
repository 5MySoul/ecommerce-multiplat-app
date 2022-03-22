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
    public class WcbcoreDaPhuongTienController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreDaPhuongTienController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreDaPhuongTien
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreDaPhuongTien>>> GetWcbcoreDaPhuongTiens()
        {
            return await _context.WcbcoreDaPhuongTiens.ToListAsync();
        }

        // GET: api/WcbcoreDaPhuongTien/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreDaPhuongTien>> GetWcbcoreDaPhuongTien(Guid id)
        {
            var wcbcoreDaPhuongTien = await _context.WcbcoreDaPhuongTiens.FindAsync(id);

            if (wcbcoreDaPhuongTien == null)
            {
                return NotFound();
            }

            return wcbcoreDaPhuongTien;
        }

        // PUT: api/WcbcoreDaPhuongTien/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreDaPhuongTien(Guid id, WcbcoreDaPhuongTien wcbcoreDaPhuongTien)
        {
            if (id != wcbcoreDaPhuongTien.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreDaPhuongTien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreDaPhuongTienExists(id))
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

        // POST: api/WcbcoreDaPhuongTien
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreDaPhuongTien>> PostWcbcoreDaPhuongTien(WcbcoreDaPhuongTien wcbcoreDaPhuongTien)
        {
            _context.WcbcoreDaPhuongTiens.Add(wcbcoreDaPhuongTien);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreDaPhuongTienExists(wcbcoreDaPhuongTien.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreDaPhuongTien", new { id = wcbcoreDaPhuongTien.Id }, wcbcoreDaPhuongTien);
        }

        // DELETE: api/WcbcoreDaPhuongTien/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreDaPhuongTien(Guid id)
        {
            var wcbcoreDaPhuongTien = await _context.WcbcoreDaPhuongTiens.FindAsync(id);
            if (wcbcoreDaPhuongTien == null)
            {
                return NotFound();
            }

            _context.WcbcoreDaPhuongTiens.Remove(wcbcoreDaPhuongTien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreDaPhuongTienExists(Guid id)
        {
            return _context.WcbcoreDaPhuongTiens.Any(e => e.Id == id);
        }
    }
}
