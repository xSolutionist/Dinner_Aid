namespace Dinner_Aid.Shared.Models;

public class Ingredient
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public IngredientType Type { get; set; }
}

public enum IngredientType
{
    Vegetable, 
    Fruit,
    Meat,
    CandyDessert,
    Beverage,
    Bread,
    Spice,
    Dairy
}
