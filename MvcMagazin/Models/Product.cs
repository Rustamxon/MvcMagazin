using System.ComponentModel.DataAnnotations;

namespace MvcMagazin.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    [DataType(DataType.Date)]
    public DateTime? LastUpdatedAt { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Type { get; set; }
    public int Count { get; set; }
}