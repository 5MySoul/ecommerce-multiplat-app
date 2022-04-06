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
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class WcbcoreNhomSanPhamController : ControllerBase
    {
        private readonly wtopshoppingcoreContext _context;

        public WcbcoreNhomSanPhamController(wtopshoppingcoreContext context)
        {
            _context = context;
        }

        // GET: api/WcbcoreNhomSanPham/GetCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WcbcoreNhomSanPham>>> GetCategories()
        {
            var categories = await _context.WcbcoreNhomSanPhams
                          .Where(c => c.LopTrenId == null)
                          .ToListAsync();
            return categories;
        }

        [HttpGet]
        public async Task<IEnumerable<WcbcoreNhomSanPham>> GetTop6Categories()
        {
            var top6CategoriesId = await _context.WcbcoreSanPhams                                        
                                        .OrderByDescending(x => x.SoLuongXem)
                                        .Select(c => c.NhomId)
                                        .Distinct()
                                        .Take(6)
                                        .ToListAsync();
            //List<WcbcoreNhomSanPham> categories = new List<WcbcoreNhomSanPham>();
            //foreach (var c in top6CategoriesId)
            //{
            //    categories.Add(_context.wcb)
            //}

            var top6Categories = await _context.WcbcoreNhomSanPhams.Where(c => top6CategoriesId.Contains(c.Id)).ToListAsync());


            return top6Categories;
        }

        // GET: api/WcbcoreNhomSanPham/GetSubCategory
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<WcbcoreNhomSanPham>>> GetSubCategory(Guid id)
        {
            var category = _context.WcbcoreNhomSanPhams
                .Where(s => s.LopTrenId == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(await category.ToListAsync());
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
