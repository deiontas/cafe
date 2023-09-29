using System;
public class ProgramUI

{
        private readonly menuitemsrepository _repo = new menuitemsrepository();

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
                                "Menu:\n"+
                                "1.Create a menu item\n"+
                                "2.List all menu items\n"+
                                "3.Get content by Mealnumber\n"+
                                "4.Update Menu item\n"+
                                "5.Remove Menu item\n"
                        
                );
                string selection = Console.ReadLine() ?? "";

                switch(selection)
                {
                        case "1":
                                Createmenuitem();
                                break;

                        default:
                                Console.WriteLine("Please enter a valid selection");
                                selectionIsValid = false;
                                break;
                        }


        } while (continueToRun);

                
}
                public void Createmenuitem()

                {
                        Console.Clear();
                        string mealnumber = GetValidStringInput("Mealnumber")
                        int mealnumber = GetValidStringInput("mealnumber");
                        string mealname = GetValidStringInput("Mealname");
                        string price = GetValidStringInput("Price");
                        double mealPrice = double.parse(price);
                        string description = GetValidStringInput("Description");
                        string ingredients = GetValidStringInput("Ingredients");
                


                 menuitems newContent = new menuitems
        (
            mealnumber, mealname, price, description, ingredients
        );
        _repo.AddContentToDirectory(newContent);
    PauseAndWaitForKeyPress();
}
//Read
    public void ListAllmenuitems()
    {
        Console.Clear();
        List<menuitems> allItems = _repo.GetAllmenuitems();

        int index = 1;
        foreach(menuitems content in allItems)
        {
            Displaymenuitem(content, index++);
        }
    PauseAndWaitForKeyPress();
    }
//Read number
    public void GetcontentByMealnumber()
    {
        Console.Clear();
        Console.Write("Please enter meal number: ");
        string number = Console.ReadLine() ?? "";
        int Mealnumber = int.Parse(number);
        menuitems item = _repo.GetcontentByMealnumber(Mealnumber);
        if (item == default)
        {
            Console.WriteLine("Meal not found");
        }
        else
        {
            Displaymenuitem(content);
        }
    PauseAndWaitForKeyPress();
    }
//Update
    public void Updatemenuitem()
    {
        Console.Clear();
        Console.Write("Please enter meal number: ");
        string number = Console.ReadLine() ?? "";
        int Mealnumber = int.Parse(number);
        Console.Clear();
    
        MenuItems item = _repo.GetcontentByMealnumber(Mealnumber);
        if (item == default)
        {
            Console.WriteLine("Meal not found");
        }
        else
        {
            Displaymenuitem(content);
            Console.WriteLine(
                "Please enter updated meal number:"
            );
            string numTwo = Console.ReadLine() ?? "";
            int updatedMealnumber = int.Parse(numTwo);
            item.Mealnumber = updatedMealnumber;
            string mealname = GetValidStringInput("Name");
            item.Mealname = meal;
            int Price = int.Parse(price);
            item.Price = Price;
            _repo.UpdateExistingItem(item.Number, item);
            string description = GetValidStringInput("Description");
            item.Description = description;
            string ingredients = GetValidStringInput("Ingredients");
            item.Ingredients = ingredients;
            
        }
    PauseAndWaitForKeyPress();
    }

//Delete
    public void Removemenuitem()
    {
        Console.Clear();
        Console.Write("Please enter the meal number you wish to delete: ");
        string num = Console.ReadLine() ?? "";
        double price = double.Parse(num);
        Console.Clear();
        _repo.DeleteExistingItem(mealname);
    PauseAndWaitForKeyPress();
    }

// Helper Methods
    private void PauseAndWaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void Displaymenuitem(menuitems content, int itemIndex)
    {
        Console.WriteLine
        (
            $"{item.Mealnumber}\n" +
            $"{item.Mealname}\n" +
            $"{item.Price}\n" +
            $"{item.Description}\n" +
            $"{item.Ingredients}\n"
        );
    }

    private void Displaymenuitem(menuitems item)
    {
        Console.WriteLine
        (
            $"{item.Mealnumber}\n" +
            $"{item.Mealname}\n" +
            $"{item.Price}\n" +
            $"{item.Description}\n" +
            $"{item.Ingredients}\n"
        );
    }

    private string GetValidStringInput(string mealname)
    {
        string input;
        do
        {
            Console.Write($"Please enter meal {name.ToLower()}:");
            input = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(mealname))
            {
                Console.WriteLine($"{mealname} cannot be empty.");
                PauseAndWaitForKeyPress();
                Console.Clear();
            }
        }
        while(string.IsNullOrWhiteSpace(mealname));
        return input;
    }
}