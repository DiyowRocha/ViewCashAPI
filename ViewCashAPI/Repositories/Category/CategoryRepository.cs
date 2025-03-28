using ViewCashAPI.Context;
using ViewCashAPI.Models;

namespace ViewCashAPI.Repositories.Category;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationContext _context;

    public CategoryRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<CategoryModel> CreateCategoryAsync(CategoryModel categoryModel)
    {
        await _context.Categories.AddAsync(categoryModel);
        await _context.SaveChangesAsync();
        return categoryModel;
    }
}