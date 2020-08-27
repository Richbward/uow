using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public interface ITransactionsRepository
    {
        Task<IEnumerable<Transaction>> GetTransactionsAsync();

        Task<int> PutTransactionItemAsync(Transaction transaction);

        Task<Transaction> GetTransactionByIdAsync(Guid Id);

        Task<bool> SaveChangesAsync();

        void UpdateTransactionAsync(Transaction transaction);
    }
}
