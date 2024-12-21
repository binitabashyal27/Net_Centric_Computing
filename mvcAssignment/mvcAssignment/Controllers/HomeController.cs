using Microsoft.AspNetCore.Mvc;
using mvcAssignment.Models;
using System.Collections.Generic;

namespace mvcAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 101, Name = "Cetaphill", Price = 1699.00m },
                new Product { Id = 102, Name = "Eyeliner", Price = 699.99m },
                new Product { Id = 103, Name = "Perfume", Price = 3999.00m }
            };

            return View(products); 
        }
    }
}
