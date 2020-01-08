using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Customer
{
    public class NewCustomerResponse:NewCustomerRequest
    {
        public int TestTblCustomerId { get; set; }
    }
}
