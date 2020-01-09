using Contracts.Customer;
using FluentValidation;
namespace WebAPI.Validators
{
    public class NewCustomerValidator:AbstractValidator<NewCustomerRequest>
    {
        public NewCustomerValidator()
        {
            RuleFor(m => m.CustomerName).NotEmpty().WithMessage("Customer Name is Require");
        }
    }
}
