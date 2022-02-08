using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiBack.Models;

namespace TaxiBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public User user = new User();


        public async Task<IActionResult> Index()
    }
}
