using Microsoft.EntityFrameworkCore;
using SyntraBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Api.Repositories
{
    public class BankDatabaseContext :DbContext
    {
        public DbSet<Account> BankAccount { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-SVE1DI5\YANNSTUDIO_01; database=SyntraBank.Database; Integrated Security=true");
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-SVE1DI5\YANNSTUDIO_01; database=VodHopper.Database; Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }




    }
}
