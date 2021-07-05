using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    /// <summary>
    /// Interface for all Methods
    /// </summary>
    interface IInventoryManager
    {
        public void DisplayProducts(List<InventoryUtility.Rice> rice);
        public void DisplayProducts(List<InventoryUtility.Wheat> Wheat);
        public void DisplayProducts(List<InventoryUtility.Pulse> pulse);
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheatList);
        public List<InventoryUtility.Rice> DeleteFromInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> DeleteFromInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> DeleteFromInventory(List<InventoryUtility.Wheat> wheatList);
        public List<InventoryUtility.Rice> EditInventory(List<InventoryUtility.Rice> riceList);
        public List<InventoryUtility.Pulse> EditInventory(List<InventoryUtility.Pulse> pulseList);
        public List<InventoryUtility.Wheat> EditInventory(List<InventoryUtility.Wheat> wheatList);
        public int CalculatePrice(int weight, int price);
    }
}
