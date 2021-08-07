using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProducts();
    }
}
