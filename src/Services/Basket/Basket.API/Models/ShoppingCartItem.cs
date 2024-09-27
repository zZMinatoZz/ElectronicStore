using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Models;
public class ShoppingCartItem
{
    public int Quantity { get; set; } = default;
    public string Color { get; set; } = default!;
    public decimal Price { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } = default!;
}