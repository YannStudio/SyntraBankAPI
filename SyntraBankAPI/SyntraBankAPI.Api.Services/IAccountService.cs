using SyntraBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Api.Services
{
    public interface IAccountService
    {
        IList<Account> GetAllAccounts();
    }
}
