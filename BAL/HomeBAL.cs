using AutoMapper;
using Contracts.Customer;
using DB.DAL.CORE;
using DB.Models.Core.DB;

using Interface.BAL;

namespace BAL
{
    public class HomeBAL: IHomeBAL
    {
        private readonly IMapper _mapper;
        public HomeBAL(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        public NewCustomerResponse Add(NewCustomerRequest newCustomerRequest)
        {
            var request = _mapper.Map<TestTblCustomerModel>(newCustomerRequest);
            var response = CRUDGeneric.Add(request);            
            return _mapper.Map<NewCustomerResponse>(response); ;
        }
    }
}
