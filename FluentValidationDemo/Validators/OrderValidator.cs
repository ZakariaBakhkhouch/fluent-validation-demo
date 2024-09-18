using FluentValidation;
using FluentValidationDemo.Extensions;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator() 
        {
            // Null & empty validation

            RuleFor(model => model.CustomerName).NotEmpty();

            // Length Validation

            RuleFor(model => model.CustomerName).MinimumLength(10);

            // Range Validation

            RuleFor(model => model.Price).InclusiveBetween(1, 1000);

            // Email Validation

            RuleFor(model => model.CustomerEmail)
                .NotEmpty()
                .EmailAddress();

            // Enum Validation

            RuleFor(model => model.OrderStatus).IsInEnum();

            // Nested Validators

            RuleFor(model => model.Product)
                .NotNull()
                .SetValidator(new ProductValidator());

            // Custom Validator

            RuleFor(model => model.CustomerName).FullName();
        }

    }
}
