using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportPit.Data;
using SportPit.Models;
using SportPit.Models.Dto;
using SportPit.Repositories.Interfaces;
using System.Diagnostics;

namespace SportPit.Controllers;

public class HomeController(
    IProductRepository productRepository, 
    IOrderRepository orderRepository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var products = await productRepository.GetAllAsync();

        return View(products);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await productRepository.GetByIdAsync(id);

        return View(product);
    }

    public IActionResult AddCart(
        int id, 
        string title, 
        string description, 
        string img, 
        decimal price)
    {
        var productCartDTO = new ProductCartDto
        {
            Id = id,
            Price = price,
            Title = title,
            Description = description,
            Img = img
        };

        orderRepository.Add(productCartDTO);

        return RedirectToAction("Index", "Cart");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
