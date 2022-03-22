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
    public class WcbcoreTinhThanhController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreTinhThanhController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreTinhThanh
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreTinhThanh>>> GetWcbcoreTinhThanhs()
        {
            return await _context.WcbcoreTinhThanhs.ToListAsync();
        }

        // GET: api/WcbcoreTinhThanh/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreTinhThanh>> GetWcbcoreTinhThanh(Guid id)
        {
            var wcbcoreTinhThanh = await _context.WcbcoreTinhThanhs.FindAsync(id);

            if (wcbcoreTinhThanh == null)
            {
                return NotFound();
            }

            return wcbcoreTinhThanh;
        }

        // PUT: api/WcbcoreTinhThanh/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreTinhThanh(Guid id, WcbcoreTinhThanh wcbcoreTinhThanh)
        {
            if (id != wcbcoreTinhThanh.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreTinhThanh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreTinhThanhExists(id))
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

        // POST: api/WcbcoreTinhThanh
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreTinhThanh>> PostWcbcoreTinhThanh(WcbcoreTinhThanh wcbcoreTinhThanh)
        {
            _context.WcbcoreTinhThanhs.Add(wcbcoreTinhThanh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreTinhThanhExists(wcbcoreTinhThanh.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreTinhThanh", new { id = wcbcoreTinhThanh.Id }, wcbcoreTinhThanh);
        }

        // DELETE: api/WcbcoreTinhThanh/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreTinhThanh(Guid id)
        {
            var wcbcoreTinhThanh = await _context.WcbcoreTinhThanhs.FindAsync(id);
            if (wcbcoreTinhThanh == null)
            {
                return NotFound();
            }

            _context.WcbcoreTinhThanhs.Remove(wcbcoreTinhThanh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreTinhThanhExists(Guid id)
        {
            return _context.WcbcoreTinhThanhs.Any(e => e.Id == id);
        }
    }
}
