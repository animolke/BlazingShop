using BlazingShop.Server.Data;
using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _dataContext;

        public ProductService(ICategoryService categoryService, DataContext dataContext)
        {
            _categoryService = categoryService;
            _dataContext = dataContext;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategory(string Uri)
        {
            Category category = await _categoryService.GetCategoryByUri(Uri);
            return await _dataContext.Products.Where(x => x.CategoryId == category.Id).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dataContext.Products.Include(p => p.Editions).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
