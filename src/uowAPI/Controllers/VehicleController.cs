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
    public class VehicleController : ControllerBase
    {
        private readonly IVehiclesRepository _vehiclesRepository;
        public VehicleController(IVehiclesRepository vehiclesRepository)
        {
            _vehiclesRepository = vehiclesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetVehicles()
        {
            var vehicles = await _vehiclesRepository.GetVehiclesAsync();
            return Ok(vehicles);
        }
    }
}
