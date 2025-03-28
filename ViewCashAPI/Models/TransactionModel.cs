using System.ComponentModel.DataAnnotations;
using ViewCashAPI.Enums;

namespace ViewCashAPI.Models;

public class TransactionModel
{
    [Key]
    public int TransactionId { get; set; }
    
    [Required]
    public string Name { get; set; }

    public string? Description { get; set; }
    
    [Required]
    public decimal Value { get; set; }

    [Required]
    public DateTime DateCreated { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? DateConcluded { get; set; }

    [Required]
    public bool IsConcluded { get; set; }

    [Required]
    public TransactionType Type { get; set; }

    public int CategoryId { get; set; }
    public CategoryModel CategoryModel { get; set; }
}