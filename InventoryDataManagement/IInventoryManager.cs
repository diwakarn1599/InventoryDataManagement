using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    interface IInventoryManager
    {
        public void DisplayProducts(List<InventoryUtility.Rice> rice);
        public void DisplayProducts(List<InventoryUtility.Wheat> Wheat);
        public void DisplayProducts(List<InventoryUtility.Pulse> pulse);
        public int CalculatePrice(int weight, int price);
    }
}
