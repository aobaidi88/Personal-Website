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
    public class ContactInfoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ContactInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactInfo>>> GetContactInfos()
        {
            return await _context.ContactInfos.ToListAsync();
        }

        // GET: api/ContactInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactInfo>> GetContactInfo(int id)
        {
            var contactInfo = await _context.ContactInfos.FindAsync(id);

            if (contactInfo == null)
            {
                return NotFound();
            }

            return contactInfo;
        }

        // PUT: api/ContactInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactInfo(int id, ContactInfo contactInfo)
        {
            if (id != contactInfo.ContactInfoID)
            {
                return BadRequest();
            }

            _context.Entry(contactInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactInfoExists(id))
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

        // POST: api/ContactInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ContactInfo>> PostContactInfo(ContactInfo contactInfo)
        {
            _context.ContactInfos.Add(contactInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactInfo", new { id = contactInfo.ContactInfoID }, contactInfo);
        }

        // DELETE: api/ContactInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContactInfo>> DeleteContactInfo(int id)
        {
            var contactInfo = await _context.ContactInfos.FindAsync(id);
            if (contactInfo == null)
            {
                return NotFound();
            }

            _context.ContactInfos.Remove(contactInfo);
            await _context.SaveChangesAsync();

            return contactInfo;
        }

        private bool ContactInfoExists(int id)
        {
            return _context.ContactInfos.Any(e => e.ContactInfoID == id);
        }
    }
}
