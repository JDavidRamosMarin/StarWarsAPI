using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STAR_WARS_API.Controllers.Entities;

namespace STAR_WARS_API.Controllers
{
    [ApiController]
    [Route("api/characters")]
    public class CharactersController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CharactersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Character>> GetAllCharacters()
        {
            return await context.Characters.ToListAsync();
        }

        [HttpGet("{id:int}")] // /api/character/id
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await context.Characters.FirstOrDefaultAsync(x => x.Id == id);

            if (character == null) return NotFound(); // Confirma que el autor exista en la BD

            return Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult> PostCharacter(Character character)
        {
            context.Add(character);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] // /api/character/id
        public async Task<ActionResult> UpdateChacarter(int id, Character character)
        {
            if (id != character.Id) return BadRequest("Los ID's deben coincidir.");

            context.Update(character);
            await context.SaveChangesAsync();
            return Ok();
        }        
        
        [HttpDelete("{id:int}")] // /api/character/id
        public async Task<ActionResult> DeleteChacarter(int id)
        {
            var dataDeleted = await context.Characters.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (dataDeleted == 0) return NotFound();

            return Ok();
        }

    }
}
