using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCompoundStoreAPI.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class DigitalCompoundAPIController : ControllerBase
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
