using ViewCashAPI.Models;
using ViewCashAPI.ViewModels.Category;

namespace ViewCashAPI.Helpers;

public static class CategoryExtensions
{
    public static CategoryViewModel ToViewModel(this CategoryModel categoryModel)
    {
        return new CategoryViewModel
        {
            CategoryId = categoryModel.CategoryId,
            Name = categoryModel.Name,
            Type = categoryModel.Type,
            IsActive = categoryModel.IsActive
        };
    }
}