using RestaurantMenu.Domain.Enums;
namespace RestaurantMenu.Domain.Entities;

public class Dish
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public bool IsVegeterian { get; set; }
    public bool IsActive { get; set; }
    public double Rating { get; set; }

    public DishCategory Category { get; set; }  // связь с enum

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}