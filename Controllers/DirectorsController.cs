using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STAR_WARS_API.Controllers.Entities;

namespace STAR_WARS_API.Controllers
{
    [ApiController]
    [Route("api/directors")]
    public class DirectorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DirectorsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Director>> GetAllDirectors()
        {
            return await context.Directors.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Director>> GetDirector(int id)
        {
            var director = await context.Directors.FirstOrDefaultAsync(x => x.Id == id);

            if (director == null) return NotFound(); 

            return Ok(director);
        }

        [HttpPost]
        public async Task<ActionResult> PostDirector(Director director)
        {
            context.Add(director);
            await context.SaveChangesAsync();
            return Ok("El director se ha agregado correctamente");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateDirector(int id, Director director)
        {
            if (id != director.Id) return NotFound("El director no se ha encontrado, verifica tu ID.");

            context.Update(director);
            await context.SaveChangesAsync();
            return Ok("El Director ha sido actualizado.");
        }

        [HttpDelete("{id:int}")] 
        public async Task<ActionResult> DeleteDirector(int id)
        {
            var dataDeleted = await context.Directors.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (dataDeleted == 0) return NotFound();

            return Ok("EL dato se ha eliminado exitosamente!!!");
        }
    }   
}
