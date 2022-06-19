using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MiniApp1.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            var userIdClaims = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;

            return Ok($"userId: {userIdClaims.Value} - userName: {userName}");
        }
    }
}
