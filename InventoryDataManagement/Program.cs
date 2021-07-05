
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Inventory Management Program**************");

            InventoryManager im = new InventoryManager();

            string jsonFilePath = @"C:\Users\NARD'S IDEAPAD\source\repos\InventoryDataManagement\InventoryDataManagement\Products.json";

            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(jsonFilePath));

            Console.WriteLine("************MENU**********");
            Console.WriteLine("1.Display Inventories \n2.Add Inventories\n3.Edit Inventories\n4.Delete Inventories\n5.Exit\nEnter Your Option");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("1.Display Rice \n2.Display Pulse\n3.Display Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.DisplayProducts(utility.riceList);
                            

                            break;
                        case 2:
                            im.DisplayProducts(utility.pulseList);
                            
                            break;
                        case 3:
                            im.DisplayProducts(utility.wheatList);
                            
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.Add Rice \n2.Add Pulse\n3.Add Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.AddToInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));

                            break;
                        case 2:
                            im.AddToInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.AddToInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("1.Edit Rice \n2.Edit Pulse\n3.Edit Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.EditInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            im.EditInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.EditInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("1.Delete Rice \n2.Delete Pulse\n3.Delete Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.DeleteFromInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            im.DeleteFromInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.DeleteFromInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    
                    break;
                case 5:
                    Console.WriteLine("Exited");
                    break;
            }


        }
    }
}
