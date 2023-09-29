using System;
using System.Collections.Generic;

public class ProgramUI
{
    private readonly MenuItemsRepository _repo = new MenuItemsRepository();

    public ProgramUI()
    {
        RunMenu();
    }

    public void RunMenu()
    {
        bool continueToRun = true;
        do
        {
            Console.Clear();
            Console.WriteLine(
                "Menu:\n" +
                "1. Create a menu item\n" +
                "2. List all menu items\n" +
                "3. Get content by Mealnumber\n" +
                "4. Update Menu item\n" +
                "5. Remove Menu item\n"
            );

            string selection = Console.ReadLine() ?? "";

            switch (selection)
            {
                case "1":
                    CreateMenuItem();
                    break;

                case "2":
                    ListAllMenuItems();
                    break;

                case "3":
                    GetContentByMealNumber();
                    break;

                case "4":
                    UpdateMenuItem();
                    break;

                case "5":
                    RemoveMenuItem();
                    break;

                default:
                    Console.WriteLine("Please enter a valid selection");
                    break;
            }
        } while (continueToRun);
    } 
    
    public void CreateMenuItem()
    {
        Console.Clear();
        string mealnumber = GetValidStringInput("Meal number");
        int mealNumber = int.Parse(mealnumber);
        string mealname = GetValidStringInput("Meal name");
        string price = GetValidStringInput("Price");
        double mealPrice = double.Parse(price);
        string description = GetValidStringInput("Description");
        string ingredients = GetValidStringInput("Ingredients");

        MenuItems newContent = new MenuItems(mealNumber, mealname, mealPrice, description, ingredients);
        _repo.AddFoodToMenu(newContent);
        PauseAndWaitForKeyPress();
    }

    public void ListAllMenuItems()
    {
        Console.Clear();
        List<MenuItems> allItems = _repo.GetAllMenuItems();

        int index = 1;
        foreach (MenuItems content in allItems)
        {
            DisplayMenuItem(content, index++);
        }
        PauseAndWaitForKeyPress();
    }

    public void GetContentByMealNumber()
    {
        Console.Clear();
        Console.Write("Please enter meal number: ");
        string number = Console.ReadLine() ?? "";
        int mealNumber = int.Parse(number);
        MenuItems item = _repo.GetContentByMealNumber(mealNumber);
        if (item == null)
        {
            Console.WriteLine("Meal not found");
        }
        else
        {
            DisplayMenuItem(item);
        }
        PauseAndWaitForKeyPress();
    }

    public void UpdateMenuItem()
    {
        Console.Clear();
        Console.Write("Please enter meal number: ");
        string number = Console.ReadLine() ?? "";
        int mealNumber = int.Parse(number);
        Console.Clear();

        MenuItems item = _repo.GetContentByMealNumber(mealNumber);
        if (item == null)
        {
            Console.WriteLine("Meal not found");
        }
        else
        {
            DisplayMenuItem(item);
            Console.WriteLine("Please enter updated meal number:");
            string numTwo = Console.ReadLine() ?? "";
            int updatedMealNumber = int.Parse(numTwo);
            item.MealNumber = updatedMealNumber;
            string mealname = GetValidStringInput("Name");
            item.MealName = mealname;
            string price = GetValidStringInput("Price");
            double updatedPrice = double.Parse(price);
            item.Price = updatedPrice;
            _repo.UpdateExistingContent(mealNumber, item);
            string description = GetValidStringInput("Description");
            item.Description = description;
            string ingredients = GetValidStringInput("Ingredients");
            item.Ingredients = ingredients;
        }
        PauseAndWaitForKeyPress();
    }

    public void RemoveMenuItem()
    {
        Console.Clear();
        Console.Write("Please enter the meal number you wish to delete: ");
        string num = Console.ReadLine() ?? "";
        int mealNumber = int.Parse(num);
        Console.Clear();
        _repo.DeleteExistingContent(mealNumber);
        PauseAndWaitForKeyPress();
    }

    private void PauseAndWaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void DisplayMenuItem(MenuItems content, int itemIndex)
    {
        Console.WriteLine(
            $"{itemIndex}.\n" +
            $"Meal number: {content.MealNumber}\n" +
            $"Meal name: {content.MealName}\n" +
            $"Price: {content.Price}\n" +
            $"Description: {content.Description}\n" +
            $"Ingredients: {content.Ingredients}\n"
        );
    }

    private void DisplayMenuItem(MenuItems item)
    {
        Console.WriteLine(
            $"Meal number: {item.MealNumber}\n" +
            $"Meal name: {item.MealName}\n" +
            $"Price: {item.Price}\n" +
            $"Description: {item.Description}\n" +
            $"Ingredients: {item.Ingredients}\n"
        );
    }

    private string GetValidStringInput(string inputName)
    {
        string input;
        do
        {
            Console.Write($"Please enter {inputName.ToLower()}: ");
            input = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"{inputName} cannot be empty.");
                PauseAndWaitForKeyPress();
                Console.Clear();
            }
        } while (string.IsNullOrWhiteSpace(input));
        return input;
    }
}
