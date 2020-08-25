using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uowAPI.Services
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<uow.Entities.Customer>> GetCustomersAsync();
    }
}
