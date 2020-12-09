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
    public class EducationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EducationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Educations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Education>>> GetEducations()
        {
            return await _context.Educations.ToListAsync();
        }

        // GET: api/Educations/5
        [HttpGet("{id}")]
        
        public async Task<ActionResult<Education>> GetEducation(int id)
        {
            var education = await _context.Educations.FindAsync(id);

            if (education == null)
            {
                return NotFound();
            }

            return education;
        }

        // PUT: api/Educations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
       
        public async Task<IActionResult> PutEducation(int id, Education education)
        {
            if (id != education.EducationID)
            {
                return BadRequest();
            }

            _context.Entry(education).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationExists(id))
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

        // POST: api/Educations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Education>> PostEducation(Education education)
        {
            _context.Educations.Add(education);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducation", new { id = education.EducationID }, education);
        }

        // DELETE: api/Educations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Education>> DeleteEducation(int id)
        {
            var education = await _context.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }

            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();

            return education;
        }

        private bool EducationExists(int id)
        {
            return _context.Educations.Any(e => e.EducationID == id);
        }
    }
}
