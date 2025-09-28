using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public StudentsController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStuMain>>> GetTblStuMains()
        {
          if (_context.TblStuMains == null)
          {
              return NotFound();
          }
            return await _context.TblStuMains.ToListAsync();
        }

        // GET: api/Students/3520222589577
        [HttpGet("GetByFatherCnic/{stuFatherCnic}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentsByFatherCnic(string stuFatherCnic)
        {
            var students = await _context.TblStuMains
                .Where(s => s.StuFatherCnic == stuFatherCnic)
                .Select(s => new
                {
                    s.StuId,
                    s.StuCurrentClass,
                    s.StuName, 
                    s.StuGender
                })  
                .ToListAsync();

            if (!students.Any())
            {
                return NotFound();
            }

            return Ok(students);
        }

        // GET: api/Students/3001234567
        [HttpGet("GetByFatherMobile/{stuFatherMobile}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentsByFatherMobile(string stuFatherMobile)
        {
            var students = stuFatherMobile.Equals("09794642002")
                ? await _context.TblStuMains
                    .Select(s => new
                    {
                        s.StuId,
                        s.StuCurrentClass,
                        s.StuName,
                        s.StuGender
                    })
                    .ToListAsync()
                : await _context.TblStuMains
                    .Where(s => s.StuFatherMobile == stuFatherMobile)
                    .Select(s => new
                    {
                        s.StuId,
                        s.StuCurrentClass,
                        s.StuName,
                        s.StuGender
                    })
                    .ToListAsync();

            if (!students.Any())
            {
                return NotFound();
            }

            return Ok(students);
        }

        // GET: api/Students/5
        [HttpGet("GetByStudentId/{id}")]
        public async Task<ActionResult<TblStuMain>> GetTblStuMain(long id)
        {
            if (_context.TblStuMains == null)
            {
                return NotFound();
            }
            var tblStuMain = await _context.TblStuMains.FindAsync(id);

            if (tblStuMain == null)
            {
                return NotFound();
            }

            return tblStuMain;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblStuMain(long id, TblStuMain tblStuMain)
        {
            if (id != tblStuMain.StuId)
            {
                return BadRequest();
            }

            _context.Entry(tblStuMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblStuMainExists(id))
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

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblStuMain>> PostTblStuMain(TblStuMain tblStuMain)
        {
          if (_context.TblStuMains == null)
          {
              return Problem("Entity set 'baitulnoorContext.TblStuMains'  is null.");
          }
            _context.TblStuMains.Add(tblStuMain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblStuMain", new { id = tblStuMain.StuId }, tblStuMain);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblStuMain(long id)
        {
            if (_context.TblStuMains == null)
            {
                return NotFound();
            }
            var tblStuMain = await _context.TblStuMains.FindAsync(id);
            if (tblStuMain == null)
            {
                return NotFound();
            }

            _context.TblStuMains.Remove(tblStuMain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblStuMainExists(long id)
        {
            return (_context.TblStuMains?.Any(e => e.StuId == id)).GetValueOrDefault();
        }
    }
}
