using AutoMapper;
using Dto;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    [ApiController]
    [Route("carburant")]
    public class CarburantController : ControllerBase
    {
        private IMapper _mapper;
        private ILoggable _logger;
        private IGestionRepos _repo;
        public CarburantController(IMapper mapper, ILoggable logger, IGestionRepos repo)
        {
            _mapper = mapper;
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetCarburants()
        {
            try
            {
                var carburant = _repo.Carburant.GetCarburants(false);

                var carburantdto = carburant.Select(elt => _mapper.Map<CarburantDto>(elt)).ToList();

                return Ok(carburantdto);
            }
            catch(Exception ex)
            {
                _logger.LogErreur("Aucun Carburant n'a été trouvé : " + ex);
                return StatusCode(500, "Erreur Serveur");
            }
            
        }
    }
}
