using AutoMapper;
using Dto;
using Entities.Models.AuthModels;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using InterfacesContrats.UserInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
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

            try
            {
                var response = _userService.Authenticate(user, _userRepo);

                var dtoResponse = _mapper.Map<UserAuthenticateDto>(response);

                return Ok(dtoResponse);
            }
            catch
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            

            
        }

    }
}
