using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WarehouseWork.Business_Logic;
using WarehouseWork.Models;

namespace WarehouseWork.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductLogic _productLogic;
        public ProductController( ProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public async Task<IActionResult> Index(int pg = 1)
        {
            //List<Product> products = _context.Products.ToList();
            //foreach (var item in data)
            //{
            //    item.manufactured = _context.Manufactureds.Where(m => m.id == item.manufacturedid).First();
            //    item.manufactured.country = _context.Countries.Where(m => m.id == item.manufactured.countryid).First();
            //}
            var products = await _productLogic.GetProductList();

            const int pageSize = 5;
            if (pg < 1)
                pg = 1;
            int recsCount = products.Count();

            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);

            //return View(products);
        }

        public async Task<IActionResult> IndexAjax()
        {
            var products = await _productLogic.GetProductList();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            Product prod = new Product();
            return View(prod);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            product.registrationDate = DateTime.Now;
            await _productLogic.Create(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            Product product = await _productLogic.Details(id);
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product product = await _productLogic.EditId(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await _productLogic.Edit(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Product product = await _productLogic.DeleteId(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            await _productLogic.Delete(product);
            return RedirectToAction("Index");
        }

        #region "Ajax Functions"

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
           await _productLogic.DeleteProduct(id);
            return Ok();
        }

        public async Task<IActionResult> ViewProduct(int id)
        {
            var prod= await _productLogic.ViewProduct(id);
            return PartialView("_detail", prod);
        }

        public async Task <IActionResult> EditProduct(int id)
        {
            var prod= await _productLogic.EditProduct(id);
            return PartialView("_Edit", prod);
        }

        public async Task<IActionResult> UpdateProduct(Product _product)
        {
            var product = await _productLogic.UpdateProduct(_product);
            return PartialView("_Product", product);
        }

        #endregion

    }
}