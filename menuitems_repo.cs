using System.Collections.Generic;



public class menuitemsrepository
{
    private readonly List<menuitems> _cafemenu = new List<menuitems>();

    //?CRUD -CREATE
    public bool AddFoodToMenu(menuitems content) 
    {
       int startingCount = _cafemenu.Count;

        _cafemenu.Add(content);

        bool wasAdded = _cafemenu.Count > startingCount;

        return wasAdded
    }

    //?READ 
    public List<menuitems> GetAllmenuitems()
    {
        return _cafemenu;
    }
    public menuitems GetcontentByMealnumber(int mealnumber)
    {
        foreach(menuitems content in _cafemenu)
        {
            if(content.Mealnumber == mealnumber)
        {
            return content;
        }
        }
            return default;
    }

    //?update
    public bool UpdateExistingContent(int originalMealnumber, menuitems newContent)
    {
        menuitems oldContent = GetcontentByMealnumber(originalMealnumber);

        if(oldContent != default)
        {
            oldContent.Mealnumber = newContent.Mealnumber;
            oldContent.Mealname = newContent.Mealname;
            oldContent.Price= newContent.Price;
            oldContent.Description = newContent.Description;
            oldContent.Ingredients = newContent.Ingredients;
            oldContent.Sandwiches = newContent.Sandwiches;
            oldContent.Selection = newContent.Selection;

            return true;
        } else {
            return false;
            }
        }


        //?Delete

        public bool  DeleteExistingContent(int Mealnumber)
        {
            menuitems contentToDelete = GetcontentByMealnumber(mealnumber);

            if(contentToDelete != default)
            {
                bool deleteResult = _cafemenu.Remove(contentToDelete);
                return  deleteResult;
            }else
                {
                return false;
                }
            }
        }
 
