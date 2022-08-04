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
        public ProductController(ProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public async Task<IActionResult> Index(int pg = 1)
        {
            try
            {
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> IndexAjax()
        {
            try
            {
                var products = await _productLogic.GetProductList();
                return View(products);

            }
            catch (Exception)
            {
                throw;
            }
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
            try
            {
                product.registrationDate = DateTime.Now;
                await _productLogic.Create(product);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                Product product = await _productLogic.Details(id);
                return View(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                Product product = await _productLogic.EditId(id);
                return View(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            try
            {
                await _productLogic.Edit(product);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Product product = await _productLogic.DeleteId(id);
                return View(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            try
            {
                await _productLogic.Delete(product);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region "Ajax Functions"

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _productLogic.DeleteProduct(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> ViewProduct(int id)
        {
            try
            {
                var prod = await _productLogic.ViewProduct(id);
                return PartialView("_detail", prod);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> EditProduct(int id)
        {
            try
            {
                var prod = await _productLogic.EditProduct(id);
                return PartialView("_Edit", prod);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> UpdateProduct(Product _product)
        {
            try
            {
                var product = await _productLogic.UpdateProduct(_product);
                return PartialView("_Product", product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}