using Microsoft.Extensions.Logging;
using PZS.Core.Interfaces;
using PZS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Infrastructure.PZS
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly PizzaStoreContext _context;
        private readonly ILogger _logger;
        public IAccountRepository Account { get; private set; }

        public UnitOfWork(PizzaStoreContext context, ILogger logger, IAccountRepository account)
        {
            _context = context;
            _logger = logger;
            Account = account;
        }

        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
