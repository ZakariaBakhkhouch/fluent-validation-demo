using FluentValidationDemo.Enums;

namespace FluentValidationDemo.Models
{
    public class Order
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Product? Product { get; set; }
    }
}
