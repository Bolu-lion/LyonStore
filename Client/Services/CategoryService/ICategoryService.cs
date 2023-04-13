using LyonStore.Shared;

namespace LyonStore.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
