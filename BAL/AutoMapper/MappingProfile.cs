using AutoMapper;
using Contracts.Customer;
using DB.Models.Core.DB;

namespace BAL.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TestTblCustomerModel, NewCustomerResponse>();
            CreateMap<NewCustomerRequest, TestTblCustomerModel>();
        }
    }
}
