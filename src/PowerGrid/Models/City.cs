using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerGrid.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Dictionary<string,bool> Sections { get; set; }
        public Dictionary<string,int> Neighbors { get; set; }
    }
}
