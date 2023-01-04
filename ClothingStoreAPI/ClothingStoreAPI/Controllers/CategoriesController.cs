using ClothingStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClothingStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categories>>> Get()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categories>> Get(int id)
        {
            var categories = await _context.Categories.FindAsync(id);
            if (categories == null)
            {
                return BadRequest("Category not found!");
            }
            return Ok(categories);
        }
    }
}
