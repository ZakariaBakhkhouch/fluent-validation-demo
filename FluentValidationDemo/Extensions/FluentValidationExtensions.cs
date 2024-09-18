using FluentValidation;

namespace FluentValidationDemo.Extensions
{
    public static class FluentValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> FullName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                       .Must(val => val.Split(" ").Length >= 2)
                       .WithMessage("Name must contain a single space");
        }
    }
}
