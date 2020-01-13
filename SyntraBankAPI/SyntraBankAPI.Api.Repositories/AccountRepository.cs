using SyntraBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyntraBankAPI.Api.Repositories
{
    public class AccountRepository : IRepository<Account>
    {
        public IList<Account> Get()
        {
			try
			{
				var context = new BankDatabaseContext();
				return context.BankAccount.ToList();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
