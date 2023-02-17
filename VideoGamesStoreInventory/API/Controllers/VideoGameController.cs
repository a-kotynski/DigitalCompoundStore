using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGamesStoreInventory.API.Controllers
{
    [ApiController]
    [Route("api/products")]
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
