using WarehouseWork.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseWork.Models;

namespace WarehouseWork.Controllers
{
    public class ProductController : Controller
    {
        private readonly WarehouseDbContext _context;
        public ProductController(WarehouseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int pg = 1)
        {
            List<Product> products = _context.Products.ToList();

            const int pageSize = 5;
            if (pg < 1)
                pg = 1;

            int recsCount = products.Count();

            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;
            foreach (var item in data)
            {
                item.manufactured =_context.Manufactureds.Where(m => m.id == item.manufacturedid).First();
                item.manufactured.country =_context.Countries.Where(m => m.id == item.manufactured.countryid).First();
            }
            return View(data);

            //return View(products);
        }

        public IActionResult IndexAjax()
        {
            List<Product> products = _context.Products.ToList();
            foreach (var item in products)
            {
                item.manufactured = _context.Manufactureds.Where(m => m.id == item.manufacturedid).First();
                item.manufactured.country = _context.Countries.Where(m => m.id == item.manufactured.countryid).First();
            }
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Product prod = new Product();
            return View(prod);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.registrationDate = DateTime.Now;
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public IActionResult Details(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.manufactured= _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country= _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            return View(prod);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.registrationDate = DateTime.Now;
            prod.manufactured = _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country = _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            return View(prod);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.manufactured = _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country = _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            return View(prod);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        #region "Ajax Functions"

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.manufactured = _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country = _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            _context.Entry(prod).State = EntityState.Deleted;
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult ViewProduct(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.manufactured = _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country = _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            return PartialView("_detail", prod);
        }

        public IActionResult EditProduct(int id)
        {
            Product prod = _context.Products.Where(p => p.id == id).FirstOrDefault();
            prod.manufactured = _context.Manufactureds.Where(m => m.id == prod.manufacturedid).First();
            prod.manufactured.country = _context.Countries.Where(m => m.id == prod.manufactured.countryid).First();
            return PartialView("_Edit", prod);
        }

        public IActionResult UpdateProduct(Product product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return PartialView("_Product", product);
        }

        #endregion

    }
}