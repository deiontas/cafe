using System.Runtime.Serialization;

public class MenuItems
{
    public int MealNumber { get; set; }
    public string MealName { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Ingredients { get; set; }

    // Default constructor
    public MenuItems() { }

    // Parameterized constructor
    public MenuItems(int mealNumber, string mealName, double price, string description, string ingredients)
    {
        MealNumber = mealNumber;
        MealName = mealName;
        Price = price;
        Description = description;
        Ingredients = ingredients;
    }
}

