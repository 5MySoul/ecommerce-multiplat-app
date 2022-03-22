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
    public class WcbcoreTinTucController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreTinTucController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreTinTuc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreTinTuc>>> GetWcbcoreTinTucs()
        {
            return await _context.WcbcoreTinTucs.ToListAsync();
        }

        // GET: api/WcbcoreTinTuc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WcbcoreTinTuc>> GetWcbcoreTinTuc(Guid id)
        {
            var wcbcoreTinTuc = await _context.WcbcoreTinTucs.FindAsync(id);

            if (wcbcoreTinTuc == null)
            {
                return NotFound();
            }

            return wcbcoreTinTuc;
        }

        // PUT: api/WcbcoreTinTuc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWcbcoreTinTuc(Guid id, WcbcoreTinTuc wcbcoreTinTuc)
        {
            if (id != wcbcoreTinTuc.Id)
            {
                return BadRequest();
            }

            _context.Entry(wcbcoreTinTuc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WcbcoreTinTucExists(id))
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

        // POST: api/WcbcoreTinTuc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WcbcoreTinTuc>> PostWcbcoreTinTuc(WcbcoreTinTuc wcbcoreTinTuc)
        {
            _context.WcbcoreTinTucs.Add(wcbcoreTinTuc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WcbcoreTinTucExists(wcbcoreTinTuc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWcbcoreTinTuc", new { id = wcbcoreTinTuc.Id }, wcbcoreTinTuc);
        }

        // DELETE: api/WcbcoreTinTuc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWcbcoreTinTuc(Guid id)
        {
            var wcbcoreTinTuc = await _context.WcbcoreTinTucs.FindAsync(id);
            if (wcbcoreTinTuc == null)
            {
                return NotFound();
            }

            _context.WcbcoreTinTucs.Remove(wcbcoreTinTuc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WcbcoreTinTucExists(Guid id)
        {
            return _context.WcbcoreTinTucs.Any(e => e.Id == id);
        }
    }
}
