using Microsoft.AspNetCore.Mvc;
using SportPit.Models.Dto;
using SportPit.Repositories.Interfaces;

namespace SportPit.Controllers;

public class CartController(IOrderRepository orderRepository) : Controller
{
    public IActionResult Index()
    {
        var cartDto = new CartDto
        {
            Price = orderRepository.Sum,
            Products = orderRepository.CountProductsByProductId
        };

        return View(cartDto);
    }
}