using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public interface IVehiclesRepository
    {
        Task<IEnumerable<Vehicle>> GetVehiclesAsync();
    }
}
