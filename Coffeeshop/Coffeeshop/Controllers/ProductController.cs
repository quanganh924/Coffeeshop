using Coffeeshop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coffeeshop.Controllers
{
    public class ProductController: Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }
    }

}
