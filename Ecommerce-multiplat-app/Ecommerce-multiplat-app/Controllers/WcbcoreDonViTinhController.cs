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
    public class WcbcoreDonViTinhController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreDonViTinhController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreDonViTinh
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreDonViTinh>>> GetWcbcoreDonViTinhs()
        {
            return await _context.WcbcoreDonViTinhs.ToListAsync();
        }

        // GET: api/WcbcoreDonViTinh/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreDonViTinh>> GetWcbcoreDonViTinh(Guid id)
        {
            var wcbcoreDonViTinh = await _context.WcbcoreDonViTinhs.FindAsync(id);

            if (wcbcoreDonViTinh == null)
            {
                return NotFound();
            }

            return wcbcoreDonViTinh;
        }

        // PUT: api/WcbcoreDonViTinh/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreDonViTinh(Guid id, WcbcoreDonViTinh wcbcoreDonViTinh)
        {
            if (id != wcbcoreDonViTinh.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreDonViTinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreDonViTinhExists(id))
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

        // POST: api/WcbcoreDonViTinh
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreDonViTinh>> PostWcbcoreDonViTinh(WcbcoreDonViTinh wcbcoreDonViTinh)
        {
            _context.WcbcoreDonViTinhs.Add(wcbcoreDonViTinh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreDonViTinhExists(wcbcoreDonViTinh.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreDonViTinh", new { id = wcbcoreDonViTinh.Id }, wcbcoreDonViTinh);
        }

        // DELETE: api/WcbcoreDonViTinh/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreDonViTinh(Guid id)
        {
            var wcbcoreDonViTinh = await _context.WcbcoreDonViTinhs.FindAsync(id);
            if (wcbcoreDonViTinh == null)
            {
                return NotFound();
            }

            _context.WcbcoreDonViTinhs.Remove(wcbcoreDonViTinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreDonViTinhExists(Guid id)
        {
            return _context.WcbcoreDonViTinhs.Any(e => e.Id == id);
        }
    }
}
