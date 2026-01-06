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
            return await _context.TblStuExams.Where(e => e.IsPosted).ToListAsync();
        }

        [HttpGet("ExamsByStudent/{stuId}")]
        public async Task<ActionResult<IEnumerable<TblStuExam>>> GetTblStuExams(int stuId)
        {
            if (_context.TblStuExams == null)
            {
                return NotFound();
            }

            // Get exams that are posted, ordered by examId descending, limited to 10
            var exams = await _context.TblStuExams
                .Where(e => e.IsPosted)
                .OrderByDescending(e => e.ExamId)
                .Take(10)
                .ToListAsync();

            // Filter exams to only those where student has results
            var examsWithResults = new List<TblStuExam>();

            foreach (var exam in exams)
            {
                bool hasResult = await _context.TblStuExamResults
                    .AnyAsync(r => r.StuId == stuId && r.ExamId == exam.ExamId);

                if (hasResult)
                {
                    examsWithResults.Add(exam);
                }
            }

            if (!examsWithResults.Any())
            {
                return NotFound();
            }

            return Ok(examsWithResults);
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
