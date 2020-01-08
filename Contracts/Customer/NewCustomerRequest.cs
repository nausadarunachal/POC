using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Customer
{
    public class NewCustomerRequest
    {
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
    }
}
