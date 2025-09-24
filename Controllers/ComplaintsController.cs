using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public ComplaintsController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/Complaints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complaint>>> GetComplaints()
        {
            if (_context.Complaints == null)
            {
                return NotFound();
            }

            return await _context.Complaints.ToListAsync();
        }

        //Example URL: https://localhost:7009/api/Complaints/GetComplaintsByID/2
        [HttpGet("GetComplaintsByID/{stuId}")]
        public async Task<ActionResult<IEnumerable<Complaint>>> GetComplaintsByID(int stuId)
        {
            if (_context.Complaints == null)
            {
                return NotFound();
            }

            var complaints = await _context.Complaints
                .Where(c => c.StuId == stuId)
                .ToListAsync();

            if (complaints == null || complaints.Count == 0)
            {
                return NotFound($"No complaints found for student ID {stuId}.");
            }

            return complaints;
        }

        //Example URL: https://localhost:7009/api/Complaints/PostComplaint/3/Hello
        [HttpPost("PostComplaint/{stuId}/{message}")]
        public async Task<ActionResult<Complaint>> PostComplaint(int stuId, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return BadRequest("Message cannot be empty.");
            }

            var complaint = new Complaint
            {
                StuId = stuId,
                Message = message,
                Date = DateTime.UtcNow
            };

            _context.Complaints.Add(complaint);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostComplaint), new { id = complaint.StuId }, complaint);
        }
    }
}
