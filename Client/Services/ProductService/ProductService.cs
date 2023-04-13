using LyonStore.Shared;
using System.Collections.Generic;

namespace LyonStore.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; }

        public void LoadProducts()
        {
            Products = new List<Product>
            {

                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "CanVas",
                    Image = "nk2.jpg",
                    Price = 77.9m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Nike CanVas",
                    Image = "nk3.jpg",
                    Price = 77.9m,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Nike",
                    Image = "nk3.jpg",
                    Price = 77.9m,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Jordan CanVas",
                    Image = "nk3.jpg",
                    Price = 77.9m,
                },
            };
        }
    }
}



