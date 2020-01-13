using SyntraBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyntraBankAPI.Api.Repositories
{
    public class AccountRepository : IRepository<Account>
    {
		public bool Create(Account item)
		{
			try
			{
				var context = new BankDatabaseContext();
				context.BankAccount.Add(item);
				context.SaveChanges();

				return true;
			}
			catch (Exception)
			{

				throw;
			}
		}

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
