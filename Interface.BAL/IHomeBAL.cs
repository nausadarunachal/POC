using Contracts.Customer;
using System;
using System.Threading.Tasks;

namespace Interface.BAL
{
    public interface IHomeBAL
    {
         NewCustomerResponse Add(NewCustomerRequest request);
    }
}
