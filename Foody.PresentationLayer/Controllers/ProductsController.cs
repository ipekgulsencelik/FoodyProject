﻿using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductList()
        {
            var value = _productService.TGetAll();
            return View(value);
        }

        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }
        
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateProduct(int id)
        {
            return View();
        }
    }
}