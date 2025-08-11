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
    public class DiaryController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public DiaryController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/Diary
        [HttpGet("StudentsDiary/{classId}/{day}/{month}/{year}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentDiary(int classId, int day, int month, int year)
        {
            DateOnly date = new DateOnly(year, month, day);
            var studentDiary = await _context.TblStuDailyDiaries
                .Where(f => f.ClassId == classId && f.Date.Day == day && f.Date.Month == month && f.Date.Year == year)
                .ToListAsync();

            if (!studentDiary.Any())
            {
                return NotFound();
            }

            return Ok(studentDiary);
        }
    }
}