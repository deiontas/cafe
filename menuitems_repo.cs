using System;
using System.Collections.Generic;

public class MenuItemsRepository
{
    private readonly List<MenuItems> _cafemenu = new List<MenuItems>();

    public MenuItemsRepository()
    {
        Seed();
    }

    // CRUD - CREATE
    public bool AddFoodToMenu(MenuItems content)
    {
        int startingCount = _cafemenu.Count;

        _cafemenu.Add(content);

        bool wasAdded = _cafemenu.Count > startingCount;

        return wasAdded;
    }

    // READ
    public List<MenuItems> GetAllMenuItems()
    {
        return _cafemenu;
    }

    public MenuItems GetContentByMealNumber(int mealNumber)
    {
        foreach (MenuItems content in _cafemenu)
        {
            if (content.MealNumber == mealNumber)
            {
                return content;
            }
        }
        return null;
    }

    // UPDATE
    public bool UpdateExistingContent(int originalMealNumber, MenuItems newContent)
    {
        MenuItems oldContent = GetContentByMealNumber(originalMealNumber);

        if (oldContent != null)
        {
            oldContent.MealNumber = newContent.MealNumber;
            oldContent.MealName = newContent.MealName;
            oldContent.Price = newContent.Price;
            oldContent.Description = newContent.Description;
            oldContent.Ingredients = newContent.Ingredients;

            return true;
        }
        else
        {
            return false;
        }
    }

    // DELETE
    public bool DeleteExistingContent(int mealNumber)
    {
        MenuItems contentToDelete = GetContentByMealNumber(mealNumber);

        if (contentToDelete != null)
        {
            bool deleteResult = _cafemenu.Remove(contentToDelete);
            return deleteResult;
        }
        else
        {
            return false;
        }
    }

    private void Seed()
    {
        MenuItems contentOne = new MenuItems(1, "Nashville Hot Chicken", 5.99, "Hot and spicy chicken", "Chicken");
        AddFoodToMenu(contentOne);
    }
}


