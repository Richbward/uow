using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uowAPI.Services
{
    public interface IGaragesRepository
    {
        Task<IEnumerable<uow.Entities.Garage>> GetGaragesAsync();
    }
}
