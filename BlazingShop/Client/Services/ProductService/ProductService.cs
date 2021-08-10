using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();
        public Product Product { get; set; } = new Product();

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadProducts(string CategoryUri = null)
        {
            if (CategoryUri == null)
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else 
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product/Category/{CategoryUri}");
            }
            
            OnChange.Invoke();
        }

        public async Task<Product> GetProductById(int id)
        { 
            return Product = await _httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}

