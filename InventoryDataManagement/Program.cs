
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


        }
    }
}
