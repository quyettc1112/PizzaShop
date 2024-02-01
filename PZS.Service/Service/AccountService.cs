using AutoMapper;
using PZS.Core.Interfaces;
using PZS.Core.Models;
using PZS.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Service.Service
{
    public class AccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AccountDTO>> GetAccountAsync()
        {
            // var account = await _unitOfWork.Account.GetAll();​
            var account = await _unitOfWork.Account.GetAll();
        return _mapper.Map<IEnumerable<AccountDTO>>(account);
        }


        public async Task<bool> InsertAsync(AccountDTO accountDTO)
        {
            var account = _mapper.Map<Account>(accountDTO);
            return await _unitOfWork.Account.Add(account);
        }

        public async Task<int> CompletedAsync()
        {
            return await _unitOfWork.CompletedAsync();
        }
    }
}
