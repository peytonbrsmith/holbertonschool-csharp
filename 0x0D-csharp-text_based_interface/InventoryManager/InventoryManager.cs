using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var types_avail = new Dictionary<string, Type>(){
                {"Item", typeof(Item)},
                {"User", typeof(User)},
                {"Inventory", typeof(Inventory)},
                // {"BaseClass", typeof(BaseClass)}
            };

            JSONStorage engine = new JSONStorage();

            string prompt = @"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>";
            Console.WriteLine(prompt);
            string line = "";
            args = line.Split(' ');
            engine.Load();

            while (line != "Exit" && line != "exit")
            {
                line = Console.ReadLine();
                args = line.Split(' ');
                if (args[0] == "All")
                {
                    if (args.Length == 1)
                    {
                        foreach (var obj in engine.All())
                        {
                            Console.WriteLine(obj);
                        }
                    }
                }
                else if (args[0] == "Create")
                {
                    if (args.Length != 2)
                    {
                        Console.WriteLine("Create [ClassName]");
                        continue;
                    }
                    switch (args[1])
                    {
                        case "Item":
                            Console.WriteLine("Enter name:");
                            string itemName = Console.ReadLine();
                            engine.New(new Item(itemName));
                            break;
                        case "User":
                            Console.WriteLine("Enter name:");
                            string userName = Console.ReadLine();
                            engine.New(new User(userName));
                            break;
                        case "Inventory":
                            Console.WriteLine("Enter USERID:");
                            string userID = Console.ReadLine();
                            Console.WriteLine("Enter ITEMID:");
                            string itemID = Console.ReadLine();
                            engine.New(new Inventory(userID, itemID));
                            break;
                        default:
                            Console.WriteLine($"{args[1]} is not a valid object type");
                            break;
                    }
                }
            }

        }
    }
}
