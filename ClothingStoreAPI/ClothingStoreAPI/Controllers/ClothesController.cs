using ClothingStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController : ControllerBase
    {

        private readonly DataContext _context;

        public ClothesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clothes>>> Get()
        {
            return Ok(await _context.Clothes.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Clothes>> Get(int id)
        {
            var clothe = await _context.Clothes.FindAsync(id);
            if (clothe == null)
            {
                return BadRequest("Clothe not found!");
            }
            return Ok(clothe);
        }

        [HttpPost]
        public async Task<ActionResult<List<Clothes>>> AddClothe(Clothes clothe)
        {
            _context.Clothes.Add(clothe);
            await _context.SaveChangesAsync();
            return Ok(await _context.Clothes.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Clothes>>> UpdateClothe(Clothes request)
        {
            var clotheToBeUpdated = await _context.Clothes.FindAsync(request.Id);
            if (clotheToBeUpdated == null)
            {
                return BadRequest("Clothe not found");
            }

            clotheToBeUpdated.Name = request.Name;
            clotheToBeUpdated.Price = request.Price;
            clotheToBeUpdated.Description = request.Description;
            clotheToBeUpdated.Status = request.Status;
            clotheToBeUpdated.Remains = request.Remains;

            await _context.SaveChangesAsync();

            return Ok(await _context.Clothes.ToListAsync());

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clothes>> DeleteClothe(int id)
        {
            var clotheToBeDeleted = await _context.Clothes.FindAsync(id);
            if (clotheToBeDeleted == null)
            {
                return BadRequest("Clothe not found!");
            }
            _context.Clothes.Remove(clotheToBeDeleted);
            await _context.SaveChangesAsync();
            return Ok($"Clothe with Id: {id} has been deleted");
        }
    }
}
