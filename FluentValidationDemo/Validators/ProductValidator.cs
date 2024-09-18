using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(model => model.Name).NotEmpty();
        }
    }
}
