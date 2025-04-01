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
    public class StudentsFeesController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public StudentsFeesController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/StudentsFees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStuFeeDueAndReceived>>> GetTblStuFeeDueAndReceiveds()
        {
            if (_context.TblStuFeeDueAndReceiveds == null)
            {
                return NotFound();
            }
            return await _context.TblStuFeeDueAndReceiveds.ToListAsync();
        }

        // GET: api/StudentsFees/GetPayableFeeByStudentId/5
        [HttpGet("GetPayableFeeByStudentId/{stuId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentPayableFees(int stuId)
        {
            var feeMonthMapping = new Dictionary<int, string>
            {
                {1, "January"}, {2, "February"}, {3, "March"}, {4, "April"},
                {5, "May"}, {6, "June"}, {7, "July"}, {8, "August"},
                {9, "September"}, {10, "October"}, {11, "November"}, {12, "December"}
            };

            var studentFees = await _context.TblStuFeeDueAndReceiveds
                .Where(f => f.StuId == stuId && f.FeeUnpaid > 0)
                .Join(_context.TblGenFeeTypes,
                    fee => fee.FeeTypeId,
                    feeType => feeType.FeeTypeId,
                    (fee, feeType) => new
                    {
                        FeeMonth = feeMonthMapping.ContainsKey(fee.FeeMonthId) ? feeMonthMapping[fee.FeeMonthId] : "Unknown",
                        FeeTypeDesc = feeType.FeeTypeDesc,
                        fee.Year,
                        fee.FeeDue,
                        fee.FeeUnpaid
                    })
                .ToListAsync();

            if (!studentFees.Any())
            {
                return NotFound();
            }

            return Ok(studentFees);
        }

        // GET: api/StudentsFees/GetPaidFeeByStudentId/5
        [HttpGet("GetPaidFeeByStudentId/{stuId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetStudentPaidFees(int stuId)
        {
            var feeMonthMapping = new Dictionary<int, string>
            {
                {1, "January"}, {2, "February"}, {3, "March"}, {4, "April"},
                {5, "May"}, {6, "June"}, {7, "July"}, {8, "August"},
                {9, "September"}, {10, "October"}, {11, "November"}, {12, "December"}
            };

            var studentFees = await _context.TblStuFeeDueAndReceiveds
                .Where(f => f.StuId == stuId && f.FeePaid > 0 && f.FeeDue == 0)
                .Join(_context.TblGenFeeTypes,
                    fee => fee.FeeTypeId,
                    feeType => feeType.FeeTypeId,
                    (fee, feeType) => new
                    {
                        fee.Date,
                        FeeMonth = feeMonthMapping.ContainsKey(fee.FeeMonthId) ? feeMonthMapping[fee.FeeMonthId] : "Unknown",
                        FeeTypeDesc = feeType.FeeTypeDesc,
                        fee.Year,
                        fee.FeePaid
                    })
                .ToListAsync();

            if (!studentFees.Any())
            {
                return NotFound();
            }

            return Ok(studentFees);
        }

        // GET: api/StudentsFees/GetByFeeTableId/5
        [HttpGet("GetByFeeTableId/{id}")]
        public async Task<ActionResult<TblStuFeeDueAndReceived>> GetTblStuFeeDueAndReceived(int id)
        {
            if (_context.TblStuFeeDueAndReceiveds == null)
            {
                return NotFound();
            }
            var tblStuFeeDueAndReceived = await _context.TblStuFeeDueAndReceiveds.FindAsync(id);

            if (tblStuFeeDueAndReceived == null)
            {
                return NotFound();
            }

            return tblStuFeeDueAndReceived;
        }

        // PUT: api/StudentsFees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblStuFeeDueAndReceived(int id, TblStuFeeDueAndReceived tblStuFeeDueAndReceived)
        {
            if (id != tblStuFeeDueAndReceived.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblStuFeeDueAndReceived).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblStuFeeDueAndReceivedExists(id))
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

        // POST: api/StudentsFees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblStuFeeDueAndReceived>> PostTblStuFeeDueAndReceived(TblStuFeeDueAndReceived tblStuFeeDueAndReceived)
        {
            if (_context.TblStuFeeDueAndReceiveds == null)
            {
                return Problem("Entity set 'baitulnoorContext.TblStuFeeDueAndReceiveds'  is null.");
            }
            _context.TblStuFeeDueAndReceiveds.Add(tblStuFeeDueAndReceived);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblStuFeeDueAndReceived", new { id = tblStuFeeDueAndReceived.Id }, tblStuFeeDueAndReceived);
        }

        // DELETE: api/StudentsFees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblStuFeeDueAndReceived(int id)
        {
            if (_context.TblStuFeeDueAndReceiveds == null)
            {
                return NotFound();
            }
            var tblStuFeeDueAndReceived = await _context.TblStuFeeDueAndReceiveds.FindAsync(id);
            if (tblStuFeeDueAndReceived == null)
            {
                return NotFound();
            }

            _context.TblStuFeeDueAndReceiveds.Remove(tblStuFeeDueAndReceived);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblStuFeeDueAndReceivedExists(int id)
        {
            return (_context.TblStuFeeDueAndReceiveds?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
