using AutoMapper;
using Dto;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    [ApiController]
    [Authorize]
    [Route("stationservice")]
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
            try
            {
                var stations = _repo.StationService.GetStationServices(false);

                var stationsdto = stations.Select(elt => _mapper.Map<StationServiceDto>(elt)).ToList();

                return Ok(stationsdto);
            }
            catch (Exception ex)
            {
                _logger.LogErreur("Echec de récupération des données : " + ex);
                return StatusCode(500, "Erreur Serveur");
            }
            
            
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetThisStation(Guid id)
        {
            try
            {
                var station = _repo.StationService.GetStationService(false, id);

                var stationdto = _mapper.Map<StationServiceDto>(station);

                return Ok(stationdto);
            }
            catch (Exception ex)
            {
                _logger.LogErreur("Echec de récupération des données : " + ex);
                return StatusCode(500, "Erreur Serveur");
            }
        }

        [HttpGet]
        [Route("carburant/{id}")]
        public IActionResult GetStationByCarburant(Guid id)
        {
            try
            {
                var station = _repo.StationService.GetStationServicesByCarburant(id);

                var stationdto = station.Select(elt => _mapper.Map<StationServiceDto>(elt)).ToList();

                return Ok(stationdto);
            }
            catch (Exception ex)
            {
                _logger.LogErreur("Echec de récupération des données : " + ex);
                return StatusCode(500, "Erreur Serveur");
            }
        }

    }
}
