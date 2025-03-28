using ViewCashAPI.DTOs;
using ViewCashAPI.Helpers;
using ViewCashAPI.Interfaces;
using ViewCashAPI.Models;
using ViewCashAPI.Repositories.Category;
using ViewCashAPI.ViewModels.Category;

namespace ViewCashAPI.Services;

public class CategoryService : ICategoryService
{
    public readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public async Task<CategoryViewModel> CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
    {
        var category = new CategoryModel
        {
            Name = createCategoryDTO.Name,
            Type = createCategoryDTO.Type,
            IsActive = true
        };
        
        var createdCategory = await _categoryRepository.CreateCategoryAsync(category);
        return createdCategory.ToViewModel();
    }
}