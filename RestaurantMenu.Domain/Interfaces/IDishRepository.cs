using RestaurantMenu.Domain.Entities;

namespace RestaurantMenu.Domain;

public interface IDishRepository
{
    Task<Dish?> GetByIdAsync(Guid id);
    Task<List<Dish>> GetAllAsync();
    Task AddAsync(Dish dish);
    Task UpdateAsync(Dish dish);
    Task DeleteAsync(Guid id);
}