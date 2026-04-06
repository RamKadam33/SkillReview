using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modules
{
    
    public class InventoryModule
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public DateTime LastUpdated { get; set; }

        public Dictionary<string, int> StatusCounts { get; set; }
    }
}
