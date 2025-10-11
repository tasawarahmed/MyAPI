using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public SubjectsController(baitulnoorContext context)
        {
            _context = context;
        }

        //https://localhost:7009/api/Subjects
        // GET: api/Subjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblStuSubject>>> GetSubjects()
        {
            if (_context.TblStuSubjects == null)
            {
                return NotFound();
            }

            return await _context.TblStuSubjects.ToListAsync();
        }
    }
}
