using AutoMapper;
using Dto;
using Entities.Models.AuthModels;
using InterfacesContrats.Logger;
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
        private IMapper _mapper;
        private ILoggable _logger;

        public UsersController(IUserService userService, IUserRepo userRepo, IMapper mapper, ILoggable logger)
        {
            _userService = userService;
            _userRepo = userRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserConnexionDto userConnexionDto)
        {
            if(userConnexionDto == null)
            {
                _logger.LogErreur("La reception du client est null");
                return BadRequest("Objet UserConnexionDto est null");
            }

            var user = _mapper.Map<AuthenticateRequest>(userConnexionDto);

            var response = _userService.Authenticate(user, _userRepo);

            if (response == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            var dtoResponse = _mapper.Map<UserAuthenticateDto>(response);

            return Ok(dtoResponse);
        }

    }
}
