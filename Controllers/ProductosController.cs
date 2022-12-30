using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBase.entities;
using NBase;

namespace EnFr2.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await context.Productos.ToListAsync();
        }


    }
}
