using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGamesStoreInventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        [HttpGet]
        public string GetVideoGames()
        {
            return "list of video games";
        }

        [HttpGet("{id}")]
        public string GetVideoGame(int id)
        {
            return "single product";
        }
    }
}
