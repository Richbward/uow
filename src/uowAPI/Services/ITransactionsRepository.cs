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

        Task<Transaction> GetTransactionByIdAsync(int Id);

        Task<bool> SaveChangesAsync();

        void UpdateTransaction(Transaction transaction);
    }
}
