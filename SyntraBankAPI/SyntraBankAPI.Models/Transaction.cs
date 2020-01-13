using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public String AcountNumber { get; set; }
        public float Amount { get; set; }
        public string Description  { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
