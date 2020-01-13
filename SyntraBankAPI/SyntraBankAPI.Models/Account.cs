using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Models
{
    public class Account
    {

        // Properties
        public string AccountNumber { get; set; }
        public Guid ClientId { get; set; }
        public float Balance { get; set; }

               
    }
}
