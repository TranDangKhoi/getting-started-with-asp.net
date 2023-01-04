using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController : ControllerBase
    {
        private static readonly List<Clothes> clothes = new List<Clothes>()
        {
                new Clothes {Id = 1, Name = "Áo gi lê phối lông cừu nhân tạo", Thumbnail = "https://static.zara.net/photos///2023/V/0/1/p/6318/022/704/2/w/850/6318022704_1_1_1.jpg?ts=1672158879737", Price = 1290000, Description="Áo gi lê cổ ve lật, tay sát nách. Có hai túi may viền ở phía trước. Hai bên may các dây đai kèm khóa cài kim loại để điều chỉnh. Lót lông cừu nhân tạo khác màu bên trong. Cài phía trước bằng khóa kéo.", Remains=10, Status=true},
                new Clothes {Id = 2, Name = "Áo gi lê phối lông bò nhân tạo", Thumbnail = "https://static.zara.net/photos///2023/V/0/1/p/6318/022/704/2/w/850/6318022704_1_1_1.jpg?ts=1672158879737" , Price = 1290000, Description="Áo gi lê cổ ve lật, tay sát nách. Có hai túi may viền ở phía trước. Hai bên may các dây đai kèm khóa cài kim loại để điều chỉnh. Lót lông bò nhân tạo khác màu bên trong. Cài phía trước bằng khóa kéo.", Remains=12, Status=true}
        };
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
