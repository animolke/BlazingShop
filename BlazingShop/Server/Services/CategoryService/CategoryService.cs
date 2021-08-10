using BlazingShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Category>> GetCategory()
        {
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUri(string CategoryUri)
        {
            return await _dataContext.Categories.FirstOrDefaultAsync(x => x.Url.ToLower().Equals(CategoryUri.ToLower()));
        }
    }
}
