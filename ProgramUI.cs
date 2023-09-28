public class ProgramUI

{
        private readonly menuitemsrepository _repo = new menuitemsrepository();

        public void Run()
        {
            menuitems contentOne = new menuitems
            (
                1,
                "Nashville Chicken",
                5.99,
                "Spicy Chicken"
                Ingredients.cheese.mustard,
                Sandwiches.chicken,
                
            );

            _repo.AddContentToDirectory(contentOne);
            Console.WriteLine(_repo.GetAllmenuitems());
            Console.WriteLine(_repo.GetAllmenuitems());
            Console.WriteLine(_repo.GetcontentByMealnumber(1).Mealnumber);
            Console.WriteLine(_repo.GetcontentByMealnumber(1).Ingredients);
        }

                public void Seed(){
                        menuitems contentOne = new menuitems
                            (
                               1,
                                 "Nashville Chicken",
                                5.99,
                                "Spicy Chicken"
                                Ingredients.cheese.mustard,
                                Sandwiches.chicken, 
                             );

                        menuitems contentTwO = new menuitems
                        (
                                2, "Turkey club burger", 6.99 "Savory turkey", Ingredients.lettuce.mustard, Sandwiches.turkey burger,
                        );
                        
                        _repo.AddContentToDirectory(contentOne);
                        _repo.AddContentToDirectory(contentTwO);
                }
                
                public void RunMenu()
                {       
                        Console.Clear();
                        Console.WriteLine(
                                "Menu:\n"+
                                "1.Create a menu item\n"+
                                "2.List all menu items\n"+
                                "3.Get content by Mealnumber\n"+
                                "4.Update Menu item\n"+
                                "5.Remove Menu item\n"+
                        
                );
                string selection = Console.ReadLine() ?? "";

                Console.WriteLine(selection);

                switch(selection)
                {
                        case "1":
                                break;

                        default:
                                Console.WriteLine("Please enter a valid selection");
                                selectionIsValid = false;
                                break;
                        }


        }

                
}