using ViewCashAPI.DTOs;
using ViewCashAPI.ViewModels.Category;

namespace ViewCashAPI.Interfaces;

public interface ICategoryService
{
    Task<CategoryViewModel> CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
}