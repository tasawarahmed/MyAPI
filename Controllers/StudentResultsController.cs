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
    public class StudentResultsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public StudentResultsController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/StudentResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStuExamResult>>> GetTblStuExamResults()
        {
            if (_context.TblStuFeeDueAndReceiveds == null)
            {
                return NotFound();
            }
            return await _context.TblStuExamResults.ToListAsync();
        }

        // GET: api/StudentsResultByStudentIdExamID/5
        [HttpGet("StudentsResultByStudentIdExamID/{stuId}/{examId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentResult(int stuId, int examId)
        {
            var studentResult = await _context.TblStuExamResults
                .Where(f => f.StuId == stuId && f.ExamId == examId)
                .Join(_context.TblStuSubjects,
                    subject => subject.SubjectId,
                    subjectType => subjectType.SubjectId,
                    (subject, subjectType) => new
                    {
                        SubjectName = subjectType.SubjectName,
                        subject.ActualMarks,
                        subject.MarksObtained
                    })
                .ToListAsync();

            if (!studentResult.Any())
            {
                return NotFound();
            }

            return Ok(studentResult);
        }
    }
}
