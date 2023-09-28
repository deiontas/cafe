
public enum Sandwiches {chicken, turkey burger}


public enum Ingredients {lettuce, cheese, pickles, ketchup, mustard, mayo}




public class menuitems
{
    public int Mealnumber {get; set; }

    public string Mealname {get; set; }

    public double Price {get; set; }

    public string Description {get; set; }

    public Ingredients Ingredients{get; set; }

    public Sandwiches Sandwiches{get; set; }




    //? constructor and parameters
    public menuitems() {}
    

    public menuitems(int Mealnumber, string Mealname, double Price, string Description, Ingredients ingredients, Sandwiches sandwiches,)
    {
        Mealnumber = mealnumber;
        Mealname = mealname;
        Price = price;
        Description =  description;
        Ingredients = ingredients;
        Sandwiches = sandwiches;
    
    
    }
}