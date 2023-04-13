using LyonStore.Shared;

namespace LyonStore.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
