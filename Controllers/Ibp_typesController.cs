using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ibp_portal_server.Context;
using ibp_portal_server.Model;

namespace ibp_portal_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ibp_typesController : ControllerBase
    {
        private readonly MyContext _context;

        public Ibp_typesController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Ibp_types
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ibp_type>>> GetIbp_types()
        {
            return await _context.Ibp_types.ToListAsync();
        }

        // GET: api/Ibp_types/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ibp_type>> GetIbp_type(int id)
        {
            var ibp_type = await _context.Ibp_types.FindAsync(id);

            if (ibp_type == null)
            {
                return NotFound();
            }

            return ibp_type;
        }

        // PUT: api/Ibp_types/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIbp_type(int id, Ibp_type ibp_type)
        {
            if (id != ibp_type.id)
            {
                return BadRequest();
            }

            _context.Entry(ibp_type).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ibp_typeExists(id))
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

        // POST: api/Ibp_types
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ibp_type>> PostIbp_type(Ibp_type ibp_type)
        {
            _context.Ibp_types.Add(ibp_type);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIbp_type", new { id = ibp_type.id }, ibp_type);
        }

        // DELETE: api/Ibp_types/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIbp_type(int id)
        {
            var ibp_type = await _context.Ibp_types.FindAsync(id);
            if (ibp_type == null)
            {
                return NotFound();
            }

            _context.Ibp_types.Remove(ibp_type);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Ibp_typeExists(int id)
        {
            return _context.Ibp_types.Any(e => e.id == id);
        }
    }
}
