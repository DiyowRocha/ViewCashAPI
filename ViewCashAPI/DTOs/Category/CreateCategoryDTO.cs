using ViewCashAPI.Enums;

namespace ViewCashAPI.DTOs;

public class CreateCategoryDTO
{
    public string Name { get; set; }
    public TransactionType Type { get; set; }
}