using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    class InventoryUtility
    {
        /// <summary>
        /// Initialization of encapsulated rice list
        /// </summary>
        public List<Rice> riceList { get;set; }
        /// <summary>
        /// Initialization of encapsulated Pulse list
        /// </summary>
        public List<Pulse> pulseList { get;set; }
        /// <summary>
        /// Initialization of encapsulated Wheat list
        /// </summary>
        public List<Wheat> wheatList { get;set; }


        /// <summary>
        /// Class for Rice inventory
        /// </summary>
        public class Rice
        {
            public string name { get;set; }
            public int weight { get; set; }
            public int price { get; set; }
        }
        /// <summary>
        /// Class for Wheat inventory
        /// </summary>
        public class Wheat
        {
            public string name { get;set; }
            public int weight { get; set; }
            public int price { get; set; }
        }
        /// <summary>
        /// Class for Pulse inventory
        /// </summary>
        public class Pulse
        {
            public string name { get;set; }
            public int weight { get; set; }
            public int price { get; set; }
        }

    }
}
