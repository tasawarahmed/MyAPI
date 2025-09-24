using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {
        private readonly baitulnoorContext _context;

        public GalleriesController(baitulnoorContext context)
        {
            _context = context;
        }

        //Example URL: https://localhost:7009/api/Galleries
        // GET: api/Galleries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gallery>>> GetGalleries()
        {
            if (_context.Galleries == null)
            {
                return NotFound();
            }

            var galleries = await _context.Galleries
                .OrderByDescending(g => g.Date ?? DateTime.MinValue) // Handles nulls by treating them as the earliest date
                .ToListAsync();

            return galleries;
        }

    }
}
