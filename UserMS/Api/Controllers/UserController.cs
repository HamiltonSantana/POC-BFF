using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<User> _logger;
        private readonly IUserServices _userService;
        public UserController(ILogger<User> logger, IUserServices userServices)
        {
            _logger = logger;
            _userService = userServices;
        }

        [HttpGet]
        public async Task<User> GetUserAsync(int id)
        {
            return await _userService.GetUser(id);
        }
        [HttpPost]
        public IActionResult UpdateUserAsync(User user)
        {
            _userService.UpdateUser(user);

            return Ok(200);
        }
    }
}