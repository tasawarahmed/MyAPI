using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public AnnouncementsController(baitulnoorContext context)
        {
            _context = context;
        }

        // GET: api/Examinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblGenAnnouncement>>> GetTblStuExams()
        {
            if (_context.TblStuExams == null)
            {
                return NotFound();
            }
            return await _context.TblGenAnnouncements.ToListAsync();
        }
    }
}
