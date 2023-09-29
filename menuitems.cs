
using System.Runtime.Serilzation;





public class menuitems
{
    public int Mealnumber {get; set; }

    public string Mealname {get; set; }

    public double Price {get; set; }

    public string Description {get; set; }
    
    public string Ingredients {get; set; }




    //? constructor and parameters
    public menuitems() {}
    

    public menuitems(int mealnumber, string mealname, double price, string description, string ingredients)
    {
        Mealnumber = mealnumber;
        Mealname = mealname;
        Price = price;
        Description =  description;
    
    
    
    }
}