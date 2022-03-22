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
    public class WcbcoreQuanHuyenController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreQuanHuyenController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreQuanHuyen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreQuanHuyen>>> GetWcbcoreQuanHuyens()
        {
            return await _context.WcbcoreQuanHuyens.ToListAsync();
        }

        // GET: api/WcbcoreQuanHuyen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreQuanHuyen>> GetWcbcoreQuanHuyen(Guid id)
        {
            var wcbcoreQuanHuyen = await _context.WcbcoreQuanHuyens.FindAsync(id);

            if (wcbcoreQuanHuyen == null)
            {
                return NotFound();
            }

            return wcbcoreQuanHuyen;
        }

        // PUT: api/WcbcoreQuanHuyen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreQuanHuyen(Guid id, WcbcoreQuanHuyen wcbcoreQuanHuyen)
        {
            if (id != wcbcoreQuanHuyen.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreQuanHuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreQuanHuyenExists(id))
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

        // POST: api/WcbcoreQuanHuyen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreQuanHuyen>> PostWcbcoreQuanHuyen(WcbcoreQuanHuyen wcbcoreQuanHuyen)
        {
            _context.WcbcoreQuanHuyens.Add(wcbcoreQuanHuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreQuanHuyenExists(wcbcoreQuanHuyen.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreQuanHuyen", new { id = wcbcoreQuanHuyen.Id }, wcbcoreQuanHuyen);
        }

        // DELETE: api/WcbcoreQuanHuyen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreQuanHuyen(Guid id)
        {
            var wcbcoreQuanHuyen = await _context.WcbcoreQuanHuyens.FindAsync(id);
            if (wcbcoreQuanHuyen == null)
            {
                return NotFound();
            }

            _context.WcbcoreQuanHuyens.Remove(wcbcoreQuanHuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreQuanHuyenExists(Guid id)
        {
            return _context.WcbcoreQuanHuyens.Any(e => e.Id == id);
        }
    }
}
