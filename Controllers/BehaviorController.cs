using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehaviorController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public BehaviorController(baitulnoorContext context)
        {
            _context = context;
        }

        [HttpGet("GetByStudent/{stuId}/{month}/{year}")]
        public async Task<IActionResult> GetStudentBehavior(int stuId, int month, int year)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var behaviorRecords = await _context.TblStuBehaviors
                .Where(b => b.StuId == stuId && b.Date >= startDate && b.Date <= endDate)
                .Join(
                    _context.TblGenBehIssues,
                    b => b.StuBehId,
                    i => i.BehIssueId,
                    (b, i) => new
                    {
                        //Date = b.Date.ToString("dd-MMM-yyyy"),
                        Date = b.Date,
                        IssueDescription = i.BehIssueDesc,
                        Remarks = b.Remarks
                    }
                )
                .OrderByDescending(r => r.Date)
                .ToListAsync();

            return Ok(behaviorRecords);
        }

        [HttpGet("GetAbsentsById/{stuId}/{month}/{year}")]
        public async Task<IActionResult> GetAbsentsById(int stuId, int month, int year)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var absents = await _context.TblStuAttendances
                .Where(a => a.StuId == stuId && a.Date >= startDate && a.Date <= endDate && a.IsAbsent)
                .OrderByDescending(a => a.Date)
                .Select(a => a.Date)
                .ToListAsync();

            return Ok(absents);
        }

        [HttpGet("GetLatesById/{stuId}/{month}/{year}")]
        public async Task<IActionResult> GetLatesById(long stuId, int month, int year)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var lates = await _context.TblStuAttendances
                .Where(a => a.StuId == stuId && a.Date >= startDate && a.Date <= endDate && a.IsLate)
                .OrderByDescending(a => a.Date)
                .Select(a => a.Date)
                .ToListAsync();

            return Ok(lates);
        }

        [HttpGet("GetPartialLeaveById/{stuId}/{month}/{year}")]
        public async Task<IActionResult> GetPartialLeaveById(long stuId, int month, int year)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var partialLeaves = await _context.TblStuAttendances
                .Where(a => a.StuId == stuId && a.Date >= startDate && a.Date <= endDate && a.PartialLeave)
                .OrderByDescending(a => a.Date)
                .Select(a => a.Date)
                .ToListAsync();

            return Ok(partialLeaves);
        }
    }
}
