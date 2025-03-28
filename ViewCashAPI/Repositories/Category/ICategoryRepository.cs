using ViewCashAPI.Models;

namespace ViewCashAPI.Repositories.Category;

public interface ICategoryRepository
{
    Task<CategoryModel> CreateCategoryAsync(CategoryModel categoryModel);
}