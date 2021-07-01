﻿using AutoMapper;
using Dto;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebAPI.Controllers
{
    [ApiController]
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
    }
}
