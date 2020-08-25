using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Models;
using uowAPI.Services;

namespace uowAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        private readonly IGaragesRepository _garagesRepository;
        public GarageController(IGaragesRepository garagesRepository)
        {
            _garagesRepository = garagesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GarageModel>>> GetGarages()
        {
            var garages = await _garagesRepository.GetGaragesAsync();
            return Ok(garages);
        }
    }
}
