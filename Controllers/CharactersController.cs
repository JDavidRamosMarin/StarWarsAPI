using Microsoft.AspNetCore.Mvc;

namespace STAR_WARS_API.Controllers
{
    [ApiController]
    [Route("/")]
    public class CharactersController: ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAllCharacters()
        {
            return Ok();
        }
    }
}
