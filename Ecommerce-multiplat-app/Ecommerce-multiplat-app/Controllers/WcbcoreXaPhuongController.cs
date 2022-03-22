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
    public class WcbcoreXaPhuongController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreXaPhuongController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreXaPhuong
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreXaPhuong>>> GetWcbcoreXaPhuongs()
        {
            return await _context.WcbcoreXaPhuongs.ToListAsync();
        }

        // GET: api/WcbcoreXaPhuong/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreXaPhuong>> GetWcbcoreXaPhuong(Guid id)
        {
            var wcbcoreXaPhuong = await _context.WcbcoreXaPhuongs.FindAsync(id);

            if (wcbcoreXaPhuong == null)
            {
                return NotFound();
            }

            return wcbcoreXaPhuong;
        }

        // PUT: api/WcbcoreXaPhuong/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreXaPhuong(Guid id, WcbcoreXaPhuong wcbcoreXaPhuong)
        {
            if (id != wcbcoreXaPhuong.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreXaPhuong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreXaPhuongExists(id))
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

        // POST: api/WcbcoreXaPhuong
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreXaPhuong>> PostWcbcoreXaPhuong(WcbcoreXaPhuong wcbcoreXaPhuong)
        {
            _context.WcbcoreXaPhuongs.Add(wcbcoreXaPhuong);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreXaPhuongExists(wcbcoreXaPhuong.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreXaPhuong", new { id = wcbcoreXaPhuong.Id }, wcbcoreXaPhuong);
        }

        // DELETE: api/WcbcoreXaPhuong/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreXaPhuong(Guid id)
        {
            var wcbcoreXaPhuong = await _context.WcbcoreXaPhuongs.FindAsync(id);
            if (wcbcoreXaPhuong == null)
            {
                return NotFound();
            }

            _context.WcbcoreXaPhuongs.Remove(wcbcoreXaPhuong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreXaPhuongExists(Guid id)
        {
            return _context.WcbcoreXaPhuongs.Any(e => e.Id == id);
        }
    }
}
