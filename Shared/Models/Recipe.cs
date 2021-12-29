namespace Dinner_Aid.Shared.Models;

public class Recipe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public DateTime DateCreated { get; set; }
    public DateTime LastUpdate { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public decimal TotalPrice { get; set; }
}
