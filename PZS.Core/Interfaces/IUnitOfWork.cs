using PZS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Projects { get; }
        Task<int> CompletedAsync();
    }
}
