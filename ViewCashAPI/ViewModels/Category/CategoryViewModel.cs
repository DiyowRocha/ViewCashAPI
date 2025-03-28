using ViewCashAPI.Enums;

namespace ViewCashAPI.ViewModels.Category;

public class CategoryViewModel
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public TransactionType Type { get; set; }
    public bool IsActive { get; set; }
}