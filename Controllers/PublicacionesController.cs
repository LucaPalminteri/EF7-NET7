using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBase;
using NBase.entities;

namespace EnFr2.Controllers
{
    [ApiController]
    [Route("api/publicaciones")]
    public class PublicacionesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PublicacionesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publicacion>>> GetPublicaciones()
        {
            return await context.Publicaciones.ToListAsync(); 
        }
    }
}
