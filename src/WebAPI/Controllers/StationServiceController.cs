using AutoMapper;
using Dto;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StationServiceController : ControllerBase
    {
        private IMapper _mapper;
        private ILoggable _logger;
        private IGestionRepos _repo;
        public StationServiceController(IMapper mapper, ILoggable logger, IGestionRepos repo)
        {
            _mapper = mapper;
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetNearStationsServices()
        {
                var stations = _repo.StationService.GetStationServices(false);

            //var stationdto = _mapper.Map<StationServiceDto>(stations);

                return Ok(stations);
            
        }
    }
}
