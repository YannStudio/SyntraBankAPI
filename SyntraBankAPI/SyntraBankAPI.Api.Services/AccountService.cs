using SyntraBankAPI.Api.Repositories;
using SyntraBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;
        public IList<Account> GetAllAccounts()
        {
            return _accountRepository.Get();
        }

        public AccountService(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }
    }
}
