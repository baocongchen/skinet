using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        private List<Product> products;

        public ProductsController(StoreContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts([FromQuery(Name = "id")] int? id) 
        {
            if (id == null) {
                products = await _context.Products.ToListAsync();
            }
            else {
                var product = await _context.Products.FindAsync(id);
                products = new List<Product>(){ product };
            }
            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct([FromQuery(Name = "id")] int? id) {
            return await _context.Products.FindAsync(id);
        }

    }
}