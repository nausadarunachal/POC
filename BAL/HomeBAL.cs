using Contracts.Customer;
using DB.DAL.CORE;
using DB.Models.Core.DB;
 
using Interface.BAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class HomeBAL: IHomeBAL
    {
        public NewCustomerResponse Add(NewCustomerRequest request)
        {
            //request.TrimAllStrings();
            TestTblCustomerModel requst = new TestTblCustomerModel
            {
                CustomerName = request.CustomerName,
                EmailAddress = request.EmailAddress,
            };
            var contactResponse = CRUDGeneric.Add(requst);
            NewCustomerResponse returnobj = new NewCustomerResponse
            {
                CustomerName = "aa",
                EmailAddress = "as",
                TestTblCustomerId = 1,
            };
            return returnobj;
        }
    }
}
