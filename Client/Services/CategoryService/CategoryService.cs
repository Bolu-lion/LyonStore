using LyonStore.Shared;

namespace LyonStore.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; }

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id=1, Name= "Canvas", Url= "Canvas", Icon="canavas"},
                new Category { Id=2, Name= "Nike", Url= "Nike", Icon="canavas"},
                new Category { Id=3, Name= "Jordan", Url= "Jordan", Icon="canavas"}
            };
        }
    }
}
