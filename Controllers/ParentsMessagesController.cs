using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsMessagesController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public ParentsMessagesController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/ParentsMessages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParentsMessage>>> GetParentsMessages()
        {
            if (_context.ParentsMessages == null)
            {
                return NotFound();
            }

            return await _context.ParentsMessages.ToListAsync();
        }

        //Example URL: https://localhost:7009/api/ParentsMessages/GetParentsMessagessByID/2
        [HttpGet("GetParentsMessagesByID/{stuId}")]
        public async Task<ActionResult<IEnumerable<ParentsMessage>>> GetParentsMessageByID(int stuId)
        {
            if (_context.ParentsMessages == null)
            {
                return NotFound();
            }

            var parentsMessages = await _context.ParentsMessages
                .Where(c => c.StuId == stuId)
                .ToListAsync();

            if (parentsMessages == null || parentsMessages.Count == 0)
            {
                return NotFound($"No parents messages found for student ID {stuId}.");
            }

            return parentsMessages;
        }

        //Example URL: https://localhost:7009/api/ParentsMessages/PostParentsMessages/4/2/New%20Message%20for%20Student%204
        [HttpPost("PostParentsMessages/{stuId}/{teacherId}/{message}")]
        public async Task<ActionResult<ParentsMessage>> PostParentsMessage(int stuId, int teacherId, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return BadRequest("Message cannot be empty.");
            }

            var parentMessage = new ParentsMessage
            {
                StuId = stuId,
                TeacherId = teacherId,
                Message = message,
                Date = DateTime.UtcNow
            };

            _context.ParentsMessages.Add(parentMessage);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostParentsMessage), new { id = parentMessage.StuId }, parentMessage);
        }
    }
}
