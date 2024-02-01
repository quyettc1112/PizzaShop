using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PZS.Core.Interfaces;
using PZS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Infrastructure.Repository
{
    public class AccountRepository: GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(PizzaStoreContext context, DbSet<Account> dbSet, ILogger logger) : base(context, dbSet, logger)
        {
        }
    
    }
}
