using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportPit.Models;

public class ProductsViewModel
{
    public required List<Product> Products { get; set; }
    public required SelectList Categories { get; set; }
    public required string? TitleProduct { get; set; }
    public required string? SelectedCategory { get; set; }

}
