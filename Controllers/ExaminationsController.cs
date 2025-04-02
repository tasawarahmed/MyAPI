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
    public class ExaminationsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public ExaminationsController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/Examinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStuExam>>> GetTblStuExams()
        {
          if (_context.TblStuExams == null)
          {
              return NotFound();
          }
            return await _context.TblStuExams.Where(e => e.IsActive).ToListAsync();
        }

        // GET: api/Examinations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblStuExam>> GetTblStuExam(int id)
        {
          if (_context.TblStuExams == null)
          {
              return NotFound();
          }
            var tblStuExam = await _context.TblStuExams.FindAsync(id);

            if (tblStuExam == null)
            {
                return NotFound();
            }

            return tblStuExam;
        }

        // PUT: api/Examinations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblStuExam(int id, TblStuExam tblStuExam)
        {
            if (id != tblStuExam.ExamId)
            {
                return BadRequest();
            }

            _context.Entry(tblStuExam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblStuExamExists(id))
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

        // POST: api/Examinations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblStuExam>> PostTblStuExam(TblStuExam tblStuExam)
        {
          if (_context.TblStuExams == null)
          {
              return Problem("Entity set 'baitulnoorContext.TblStuExams'  is null.");
          }
            _context.TblStuExams.Add(tblStuExam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblStuExam", new { id = tblStuExam.ExamId }, tblStuExam);
        }

        // DELETE: api/Examinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblStuExam(int id)
        {
            if (_context.TblStuExams == null)
            {
                return NotFound();
            }
            var tblStuExam = await _context.TblStuExams.FindAsync(id);
            if (tblStuExam == null)
            {
                return NotFound();
            }

            _context.TblStuExams.Remove(tblStuExam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblStuExamExists(int id)
        {
            return (_context.TblStuExams?.Any(e => e.ExamId == id)).GetValueOrDefault();
        }
    }
}
