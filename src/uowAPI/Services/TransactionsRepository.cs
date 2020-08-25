using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly uowContext _context;
        private readonly ILogger<TransactionsRepository> _logger;
        private CancellationTokenSource _cancellationTokenSource;

        public TransactionsRepository(uowContext context,
            ILogger<TransactionsRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public TransactionsRepository(uowContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetTransactionByIdAsync(int Id)
        {
            return await _context.Transactions.FindAsync(Id);
        }

        public async Task<int> PutTransactionItemAsync(Transaction transaction)
        {

            _context.Entry(transaction).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            // return true if 1 or more entities were changed
            return (await _context.SaveChangesAsync() > 0);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            // Nothing to do - patch takes care of it for us.
        }

        // TODO = Possibly later (Allow cancellation of put/patch)
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_context != null)
        //        {
        //            _context.Dispose();
        //            _context = null;
        //        }
        //        if (_cancellationTokenSource != null)
        //        {
        //            _cancellationTokenSource.Dispose();
        //            _cancellationTokenSource = null;
        //        }
        //    }
        //}
    }
}
