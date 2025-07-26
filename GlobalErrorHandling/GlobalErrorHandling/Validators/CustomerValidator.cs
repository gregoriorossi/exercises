using FluentValidation;
using GlobalErrorHandling.Models;

namespace GlobalErrorHandling.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() { 
            RuleFor(customer => customer.Name).NotEmpty();
            RuleFor(customer => customer.Surname).NotEmpty();
            RuleFor(customer => customer.Email).EmailAddress();
        }
    }
}
