    using System;
    using Newtonsoft.Json.Linq;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
    public class CRUDJ
    {
        public static void CRUDDo()
        {


            string filePath = "shoppingList.json";
            JArray shoppingList;

            if (File.Exists(filePath))
            {
                // Read existing shopping list from file
                string shoppingListJson = File.ReadAllText(filePath);
                shoppingList = JArray.Parse(shoppingListJson);
            }
            else
            {
                // Create new shopping list
                shoppingList = new JArray();
            }

            bool running = true;
            while (running)
            {
                Console.WriteLine("Shopping List");
                Console.WriteLine("-------------");
                Console.WriteLine();

                // Display current items in shopping list
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    JToken item = shoppingList[i];
                    Console.WriteLine($"{i + 1}. {item["name"]} ({item["quantity"]})");
                }

                Console.WriteLine();
                Console.WriteLine("Type any of the commands:");
                Console.WriteLine(" -- add ");
                Console.WriteLine(" -- update ");
                Console.WriteLine(" -- remove ");
                Console.WriteLine(" -- exit");

          
                Console.Write("Choose the option : ");
                string input = Console.ReadLine().Trim();
                string[] parts = input.Split(' ');

                // Process user input
                if (parts.Length > 0)
                {
                    string command = parts[0];

                    switch (command)
                    {
                        case "add":
                            if (parts.Length == 3)
                            {
                                string name = parts[1];
                                int quantity;
                                if (int.TryParse(parts[2], out quantity))
                                {
                                    JObject newItem = new JObject();
                                    newItem["name"] = name;
                                    newItem["quantity"] = quantity;
                                    shoppingList.Add(newItem);

                                    Console.WriteLine($"{name} ({quantity}) added to shopping list.");
                                }
                                else
                                {
                                    Console.WriteLine("Quantity must be a number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Usage: add <name> <quantity>");
                            }
                            break;

                        case "update":
                            if (parts.Length == 4)
                            {
                                int index;
                                if (int.TryParse(parts[1], out index) && index > 0 && index <= shoppingList.Count)
                                {
                                    string name = parts[2];
                                    int quantity;
                                    if (int.TryParse(parts[3], out quantity))
                                    {
                                        JObject item = (JObject)shoppingList[index - 1];
                                        item["name"] = name;
                                        item["quantity"] = quantity;

                                        Console.WriteLine($"Item {index} updated to {name} ({quantity}).");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantity must be a number.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Index must be a valid number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Usage: update <index> <name> <quantity>");
                            }
                            break;

                        case "remove":
                            if (parts.Length == 2)
                            {
                                int index;
                                if (int.TryParse(parts[1], out index) && index > 0 && index <= shoppingList.Count)
                                {
                                    JToken item = shoppingList[index - 1];
                                    shoppingList.RemoveAt(index - 1);

                                    Console.WriteLine($"{item["name"]} ({item["quantity"]}) removed from shopping list.");
                                }
                                else
                                {
                                    Console.WriteLine("Index must be a valid number.");
                                }
                            } break;

                    }
                }
            }
        }
    }
}

        

    

