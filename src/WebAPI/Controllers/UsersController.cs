using Entities.Models.AuthModels;
using InterfacesContrats.RepositoryInterfaces;
using InterfacesContrats.UserInterfaces;
using Microsoft.AspNetCore.Mvc;



namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private IUserRepo _userRepo;

        public UsersController(IUserService userService, IUserRepo userRepo)
        {
            _userService = userService;
            _userRepo = userRepo;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model, _userRepo);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

    }
}
