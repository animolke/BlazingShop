using BlazingShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>() {
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Video Games", Url = "video-games", Icon = "aperture" },
                new Category { Id = 3, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 4, Name = "Movies", Url = "movies", Icon = "tag" } };

        public async Task<List<Category>> GetCategory()
        {
            return Categories;
        }
    }
}
