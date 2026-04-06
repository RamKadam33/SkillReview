using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modules
{
   public class OrderModule
    {
       
            public long Id { get; set; }
            public long PetId { get; set; }
            public int Quantity { get; set; }
        [JsonProperty("shipDate")]
        public string ShipDateRaw { get; set; }

        public string Status { get; set; }
            public bool Complete { get; set; }

        public DateTime? ShipDate
        {
            get
            {
                if (DateTime.TryParse(ShipDateRaw, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                return null; // Handle invalid formats safely
            }
        }

    }
}
