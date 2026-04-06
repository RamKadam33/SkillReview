using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLayer.Modules
{
  


    public class GetPetById
    {
        public long Id { get; set; }
        //public Category Category { get; set; }
        public string Name { get; set; }
        public List<string> PhotoUrls { get; set; }
        public List<Tag> Tags { get; set; }  
        public string Status { get; set; }
    }

    public class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }




}
