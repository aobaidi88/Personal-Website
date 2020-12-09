using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Server.Data;
using PersonalWebsite.Shared;

namespace PersonalWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperincesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExperincesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Experinces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experince>>> GetExperinces()
        {
            return await _context.Experinces.ToListAsync();
        }

        // GET: api/Experinces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Experince>> GetExperince(int id)
        {
            var experince = await _context.Experinces.FindAsync(id);

            if (experince == null)
            {
                return NotFound();
            }

            return experince;
        }

        // PUT: api/Experinces/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExperince(int id, Experince experince)
        {
            if (id != experince.ExperincenceID)
            {
                return BadRequest();
            }

            _context.Entry(experince).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperinceExists(id))
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

        // POST: api/Experinces
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Experince>> PostExperince(Experince experince)
        {
            _context.Experinces.Add(experince);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExperince", new { id = experince.ExperincenceID }, experince);
        }

        // DELETE: api/Experinces/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Experince>> DeleteExperince(int id)
        {
            var experince = await _context.Experinces.FindAsync(id);
            if (experince == null)
            {
                return NotFound();
            }

            _context.Experinces.Remove(experince);
            await _context.SaveChangesAsync();

            return experince;
        }

        private bool ExperinceExists(int id)
        {
            return _context.Experinces.Any(e => e.ExperincenceID == id);
        }
    }
}
