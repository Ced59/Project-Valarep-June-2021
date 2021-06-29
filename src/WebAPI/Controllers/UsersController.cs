using AutoMapper;
using Dto;
using Entities.Models;
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
        private IGestionRepos _repo;

        public UsersController(IUserService userService, IUserRepo userRepo, IGestionRepos repo, IMapper mapper, ILoggable logger)
        {
            _userService = userService;
            _userRepo = userRepo;
            _mapper = mapper;
            _logger = logger;
            _repo = repo;
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

        [HttpPost]
        public IActionResult Subscribe([FromBody] UserCreationDto userCreationDto)
        {
            if (userCreationDto == null)
            {
                _logger.LogErreur("La reception du client est null");
                return BadRequest("Objet userCreationDto est null");
            }

            if(userCreationDto.Password == userCreationDto.PasswordConfirm)
            {
                var user = _mapper.Map<User>(userCreationDto);

                _repo.User.CreerUser(user);
                _repo.Save();

                return Ok(new { message = "Merci pour votre inscription veuillez vous indentifier" });
            }
            else
            {
                return BadRequest(new { message = "Une erreur s'est produite" });
            }
            

            
        }

    }
}
