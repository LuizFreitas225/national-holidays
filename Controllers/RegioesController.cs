using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nationalHolidays.Data;
using nationalHolidays.Model;

namespace nationalHolidays.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegioesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public RegioesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Regioes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Regiao>>> GetRegioes()
        {
          if (_context.Regioes == null)
          {
              return NotFound();
          }
            return await _context.Regioes.ToListAsync();
        }

        // GET: api/Regioes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Regiao>> GetRegiao(long id)
        {
          if (_context.Regioes == null)
          {
              return NotFound();
          }
            var regiao = await _context.Regioes.FindAsync(id);

            if (regiao == null)
            {
                return NotFound();
            }

            return regiao;
        }

        // PUT: api/Regioes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegiao(long id, Regiao regiao)
        {
            if (id != regiao.Id)
            {
                return BadRequest();
            }

            _context.Entry(regiao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegiaoExists(id))
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

        // POST: api/Regioes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Regiao>> PostRegiao(Regiao regiao)
        {
          if (_context.Regioes == null)
          {
              return Problem("Entity set 'DataBaseContext.Regioes'  is null.");
          }
            _context.Regioes.Add(regiao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegiao", new { id = regiao.Id }, regiao);
        }

        // DELETE: api/Regioes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegiao(long id)
        {
            if (_context.Regioes == null)
            {
                return NotFound();
            }
            var regiao = await _context.Regioes.FindAsync(id);
            if (regiao == null)
            {
                return NotFound();
            }

            _context.Regioes.Remove(regiao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegiaoExists(long id)
        {
            return (_context.Regioes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
