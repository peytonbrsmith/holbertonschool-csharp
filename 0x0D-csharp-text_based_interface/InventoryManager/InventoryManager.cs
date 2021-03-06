using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InventoryLibrary;
using System.Reflection;
using System.Text.Json;
namespace InventoryManager
{
    class Program
    {
        /// <summary>
        /// Prompt for console interface
        /// </summary>
        public static string prompt = @"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>
";

        /// <summary>
        /// Dictionary of available types
        /// </summary>
        public static Dictionary<string, Type> types_avail = new Dictionary<string, Type>(){
            {"item", typeof(Item)},
            {"user", typeof(User)},
            {"inventory", typeof(Inventory)},
            // {"BaseClass", typeof(BaseClass)}
        };
        static void Main(string[] args)
        {
            // Initialize JSON storage
            // or replace with database
            JSONStorage engine = new JSONStorage();

            // Console interface handling

            Console.WriteLine(prompt);
            string line = "";
            args = line.Split(' ');

            // Read input until we exit

            while (line != "Exit" && line != "exit")
            {
                line = Console.ReadLine().Trim();
                args = line.Split(' ');
                if (args.Length >= 1)
                    args[0] = args[0].ToLower();
                if (args.Length >= 2)
                    args[1] = args[1].ToLower();
                
                // Check input for available commands

                switch (args[0])
                {
                    case "create":
                        Create(args, engine);
                        break;
                    case "classnames":
                        foreach (KeyValuePair<string, Type> kvp in types_avail)
                        {
                            Console.WriteLine(kvp.Key);
                        }
                        break;
                    case "show":
                        Show(args, engine);
                        break;
                    case "update":
                        Update(args, engine);
                        break;
                    case "delete":
                        Delete(args, engine);
                        break;
                    case "all":
                        All(args, engine);
                        break;
                }
            }
        }


        /// <summary>
        /// Shows all objects currently loaded
        /// </summary>
        /// <param name="args"></param>
        /// <param name="engine"></param>
        static void All(string[] args, JSONStorage engine)
        {
            if (args.Length == 1)
            {
                foreach (var obj in engine.All())
                {
                    Console.WriteLine(obj);
                }
            }
            else if (args.Length == 2)
            {
                if (!types_avail.ContainsKey(args[1]))
                {
                    Console.WriteLine($"{args[1]} is not a valid object type");
                    return;
                }
                foreach (KeyValuePair<string, Object> obj in engine.All())
                {
                    if (obj.Key.Split('.')[0].ToLower() == args[1])
                    {
                        Console.WriteLine(obj);
                    }
                }
            }
            Console.WriteLine(prompt);
        }

        /// <summary>
        /// Shows object of class and given ID
        /// </summary>
        /// <param name="args"></param>
        /// <param name="engine"></param>
        static void Show(string[] args, JSONStorage engine)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Show <ClassName> <id>");
                return;
            }
            else if (!types_avail.ContainsKey(args[1]))
            {
                Console.WriteLine($"{args[1]} is not a valid object type");
                return;
            }
            else
            {
                if (engine.All().ContainsKey(args[1] + "." + args[2]))
                {
                    engine.All().TryGetValue(args[1] + "." + args[2], out Object obj);
                    Console.WriteLine(obj);
                }
                else
                {
                    Console.WriteLine("No such object");
                    return;
                }
            }
            Console.WriteLine(prompt);
        }

        /// <summary>
        /// Creates new object of given classname
        /// </summary>
        /// <param name="args"></param>
        /// <param name="engine"></param>
        static void Create(string[] args, JSONStorage engine)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Create [ClassName]");
                return;
            }
            else
            {
                switch (args[1])
                {
                    case "item":
                        Console.WriteLine("Enter name (Required):");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Optional Properties (Leave blank for default):");
                        Console.WriteLine("Enter Description (Optional):");
                        string itemDesc = Console.ReadLine();
                        Console.WriteLine("Enter Price (Optional):");
                        bool isPrice = float.TryParse(Console.ReadLine(), out float itemPrice);
                        if (!isPrice)
                        {
                            itemPrice = 0.0f;
                        }
                        Console.WriteLine("Enter Tags (Optional) Seperate with commas:");
                        List<string> itemTags = new List<string>(Console.ReadLine().Replace(" ", "").Split(','));
                        engine.New(new Item(itemName, itemDesc, itemPrice, itemTags));
                        break;
                    case "user":
                        Console.WriteLine("Enter name:");
                        string userName = Console.ReadLine();
                        engine.New(new User(userName));
                        break;
                    case "inventory":
                        Console.WriteLine("Enter USERID:");
                        string userID = Console.ReadLine();
                        if (!checkKey(userID, engine, "user"))
                            return;
                        Console.WriteLine("Enter ITEMID:");
                        string itemID = Console.ReadLine();
                        if (!checkKey(itemID, engine, "item"))
                            return;
                        Console.WriteLine("Enter Quantity:");
                        bool isQnt= int.TryParse(Console.ReadLine(), out int itemQnt);
                        if (!isQnt)
                        {
                            itemQnt = 1;
                        }
                        engine.New(new Inventory(userID, itemID, itemQnt));
                        break;
                    default:
                        Console.WriteLine($"{args[1]} is not a valid object type");
                        return;
                }
            }
            Console.WriteLine(prompt);
        }

        /// <summary>
        /// Deletes object of given class and ID
        /// </summary>
        /// <param name="args"></param>
        /// <param name="engine"></param>
        static void Delete(string[] args, JSONStorage engine)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Delete [ClassName] [object_id]");
                return;
            }
            else if (!types_avail.ContainsKey(args[1]))
            {
                Console.WriteLine($"{args[1]} is not a valid object type");
                return;
            }
            else
            {
                string obj_id = args[1] + "." + args[2];

                if (engine.All().ContainsKey(obj_id))
                {
                    Console.WriteLine("Are you sure you want to delete this object? (y/n)");
                    string line = Console.ReadLine();
                    if (line.ToLower() == "y")
                    {
                        engine.All().Remove(obj_id);
                        Console.WriteLine("Object deleted");
                    }
                    else
                    {
                        Console.WriteLine("Object not deleted");
                    }
                }
                else
                {
                    Console.WriteLine($"Object {obj_id} could not be found");
                    return;
                }
            }
            engine.Save();
            Console.WriteLine(prompt);
        }


        /// <summary>
        /// Updates object of class and ID
        /// </summary>
        /// <param name="args"></param>
        /// <param name="engine"></param>
        static void Update(string[] args, JSONStorage engine)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Update [ClassName] [object_id]");
                return;
            }
            else if (!types_avail.ContainsKey(args[1]))
            {
                Console.WriteLine($"{args[1]} is not a valid object type");
                return;
            }
            else
            {
                string obj_id = args[1] + "." + args[2];

                if (engine.All().ContainsKey(obj_id))
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                        IgnoreNullValues = true,
                        WriteIndented = true
                    };
                    object updateObj;
                    switch (args[1])
                    {
                        case "item":
                            updateObj = JsonSerializer.Deserialize<Item>(engine.All()[obj_id].ToString(), options);
                            break;
                        case "user":
                            updateObj = JsonSerializer.Deserialize<User>(engine.All()[obj_id].ToString(), options);
                            break;
                        case "inventory":
                            updateObj = JsonSerializer.Deserialize<Inventory>(engine.All()[obj_id].ToString(), options);
                            break;
                        default:
                            updateObj = JsonSerializer.Deserialize<BaseClass>(engine.All()[obj_id].ToString(), options);
                            break;
                    }
                    engine.All().Remove(obj_id);
                    foreach (PropertyInfo prop in updateObj.GetType().GetProperties())
                        {
                            if (prop.Name == "Date_updated")
                            {
                                prop.SetValue(updateObj, DateTime.Now);
                                continue;
                            }
                            if (prop.Name == "Id")
                            {
                                prop.SetValue(updateObj, obj_id.Split('.')[1]);
                                continue;
                            }
                            if (prop.Name == "Tags")
                            {
                                Console.Write($"Change {prop.Name} from [");
                                try{
                                    foreach (string tag in (List<string>)prop.GetValue(updateObj))
                                    {
                                        Console.Write($"{tag}, ");
                                    }
                                }
                                catch {}
                                Console.WriteLine("] To:");
                                List<string> itemTags = new List<string>(Console.ReadLine().Replace(" ", "").Split(','));
                                if (itemTags != null && itemTags.Count > 0)
                                {
                                    prop.SetValue(updateObj, itemTags);
                                }
                                continue;
                            }
                            if (prop.GetSetMethod() != null)
                            {
                                Console.WriteLine($"Change {prop.Name} from \"{prop.GetValue(updateObj)}\" to:");
                                string line = Console.ReadLine();

                                if (prop.GetValue(updateObj) == null || prop.GetValue(updateObj).GetType() == typeof(string))
                                {
                                    if (line != "")
                                    {
                                        prop.SetValue(updateObj, line);
                                    }
                                }
                                else if (prop.GetValue(updateObj).GetType() == typeof(int))
                                {
                                    bool isInt = int.TryParse(line, out int intVal);
                                    if (isInt)
                                    {
                                        prop.SetValue(updateObj, intVal);
                                    }
                                }
                                else if (prop.GetValue(updateObj).GetType() == typeof(float))
                                {
                                    bool isFloat = float.TryParse(line, out float fltVal);
                                    if (isFloat)
                                    {
                                        prop.SetValue(updateObj, fltVal);
                                    }
                                }
                            }
                        }
                    engine.New((BaseClass) updateObj);
                }
                else
                {
                    Console.WriteLine($"Object {obj_id} could not be found");
                    return;
                }
            }
            engine.Save();
            Console.WriteLine(prompt);
        }


        /// <summary>
        /// Checks if ID is valid in storage engine
        /// </summary>
        /// <param name="inkey"></param>
        /// <param name="engine"></param>
        /// <param name="idType"></param>
        /// <returns></returns>
        static bool checkKey(string inkey, JSONStorage engine, string idType)
        {
            inkey = idType + "." + inkey;
            foreach (string key in engine.All().Keys)
            {
                if (key == inkey)
                {
                    return true;
                }
            }
            Console.WriteLine("No such ID exists for " + idType);
            return false;
        }
    }
}
