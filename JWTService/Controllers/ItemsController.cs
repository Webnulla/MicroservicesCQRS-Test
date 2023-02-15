using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTService.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        public List<string> ColorList = new List<string>() { "blue", "red", "white"};

        [HttpGet]
        public List<string> GetColor()
        {
            try
            {
                return ColorList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
