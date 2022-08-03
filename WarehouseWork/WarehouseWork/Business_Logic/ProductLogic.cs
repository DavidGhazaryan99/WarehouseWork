using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseWork.Data;
using WarehouseWork.Models;

namespace WarehouseWork.Business_Logic
{
    public class ProductLogic
    {
        private readonly WarehouseDbContext _context;
        public ProductLogic(WarehouseDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductList(int pg = 1)
        {
            try
            {
                List<Product> products = await _context.Products.ToListAsync();
                foreach (var item in products)
                {
                    item.manufactured = await _context.Manufactureds.Where(m => m.id == item.manufacturedid).FirstAsync();
                    item.manufactured.country = await _context.Countries.Where(m => m.id == item.manufactured.countryid).FirstAsync();
                }
                return products;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task Create(Product product)
        {
            try
            {
                product.registrationDate = DateTime.Now;
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Product> Details(int id)
        {
            Product prod = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            prod.manufactured = await _context.Manufactureds.Where(m => m.id == prod.manufacturedid).FirstAsync();
            prod.manufactured.country = await _context.Countries.Where(m => m.id == prod.manufactured.countryid).FirstAsync();
            return prod;
        }
        public async Task<Product> EditId(int id)
        {
            Product prod = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            prod.registrationDate = DateTime.Now;
            prod.manufactured = await _context.Manufactureds.Where(m => m.id == prod.manufacturedid).FirstAsync();
            prod.manufactured.country = await _context.Countries.Where(m => m.id == prod.manufactured.countryid).FirstAsync();
            return prod;
        }
        public async Task Edit(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<Product> DeleteId(int id)
        {
            Product product = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            product.manufactured = await _context.Manufactureds.Where(m => m.id == product.manufacturedid).FirstAsync();
            product.manufactured.country = await _context.Countries.Where(m => m.id == product.manufactured.countryid).FirstAsync();
            return product;
        }
        public async Task Delete(Product product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProduct(int id)
        {
            Product prod = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            prod.manufactured = await _context.Manufactureds.Where(m => m.id == prod.manufacturedid).FirstAsync();
            prod.manufactured.country = await _context.Countries.Where(m => m.id == prod.manufactured.countryid).FirstAsync();
            _context.Entry(prod).State = EntityState.Deleted;
            _context.SaveChanges();
        }
        public async Task<Product> ViewProduct(int id)
        {
            Product prod = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            prod.manufactured = await _context.Manufactureds.Where(m => m.id == prod.manufacturedid).FirstAsync();
            prod.manufactured.country = await _context.Countries.Where(m => m.id == prod.manufactured.countryid).FirstAsync();
            return prod;
        }
        public async Task<Product> EditProduct(int id)
        {
            Product prod = await _context.Products.Where(p => p.id == id).FirstOrDefaultAsync();
            prod.manufactured = await _context.Manufactureds.Where(m => m.id == prod.manufacturedid).FirstAsync();
            prod.manufactured.country = await _context.Countries.Where(m => m.id == prod.manufactured.countryid).FirstAsync();
            return prod;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
