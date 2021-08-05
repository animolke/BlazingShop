using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>() {
                new Product {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Life Of Pie",
                    Description = "The son of a zookeeper, Pi Patel has an encyclopedic knowledge of animal behavior and a fervent love of stories. When Pi is sixteen, his family emigrates from India to North America aboard a Japanese cargo ship, along with their zoo animals bound for new homes",
                    Image = "https://upload.wikimedia.org/wikipedia/en/4/45/Life_of_Pi_cover.png",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Farcry 5",
                    Description = "The game takes place in Hope County, a fictional region of Montana, United States. The main story revolves around the Project at Eden's Gate, a doomsday cult that has taken over the county at the command of its charismatic and powerful leader, Joseph Seed. ",
                    Image = "https://upload.wikimedia.org/wikipedia/en/0/03/Far_Cry_5_boxshot.jpg",
                    Price = 8.19m,
                    OriginalPrice = 39.99m
                },
                new Product {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Playstation 5 (PS5)",
                    Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png",
                    Price = 399.99m,
                    OriginalPrice = 499.99m
                },
                new Product {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Sarpatta Parambarai",
                    Description = "Sarpatta Parambarai, or alternatively Sarpatta tradition, is a 2021 Indian Tamil-language sports action film directed by Pa. Ranjith, who also co-produced the film under his banner Neelam Productions",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a6/Sarpatta_Parambarai.jpg",
                    Price = 20.19m,
                    OriginalPrice = 40.29m
                }
            };
        }
    }
}
