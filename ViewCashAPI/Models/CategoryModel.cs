using System.ComponentModel.DataAnnotations;
using System.Transactions;
using ViewCashAPI.Enums;

namespace ViewCashAPI.Models;

public class CategoryModel
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public TransactionType Type { get; set; }
    [Required]
    public bool IsActive { get; set; }

    public List<TransactionModel> Transactions { get; set; } = new List<TransactionModel>();
}