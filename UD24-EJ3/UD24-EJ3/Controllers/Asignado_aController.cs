using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UD24_EJ3.Models;

namespace UD24_EJ3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Asignado_aController : ControllerBase
    {
        private readonly APIContext _context;

        public Asignado_aController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Asignado_a
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asignado_a>>> GetAsignados_a()
        {
            return await _context.Asignados_a.ToListAsync();
        }

        // GET: api/Asignado_a/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asignado_a>> GetAsignado_a(int id)
        {
            var asignado_a = await _context.Asignados_a.FindAsync(id);

            if (asignado_a == null)
            {
                return NotFound();
            }

            return asignado_a;
        }

        // PUT: api/Asignado_a/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsignado_a(int id, Asignado_a asignado_a)
        {
            if (id != asignado_a.Id)
            {
                return BadRequest();
            }

            _context.Entry(asignado_a).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Asignado_aExists(id))
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

        // POST: api/Asignado_a
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Asignado_a>> PostAsignado_a(Asignado_a asignado_a)
        {
            _context.Asignados_a.Add(asignado_a);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsignado_a", new { id = asignado_a.Id }, asignado_a);
        }

        // DELETE: api/Asignado_a/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Asignado_a>> DeleteAsignado_a(int id)
        {
            var asignado_a = await _context.Asignados_a.FindAsync(id);
            if (asignado_a == null)
            {
                return NotFound();
            }

            _context.Asignados_a.Remove(asignado_a);
            await _context.SaveChangesAsync();

            return asignado_a;
        }

        private bool Asignado_aExists(int id)
        {
            return _context.Asignados_a.Any(e => e.Id == id);
        }
    }
}
