using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerGrid.Models
{
    public class Player
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public Dictionary<string,int> ResourceStock { get; set; }
        public int Houses { get; set; }
        public ICollection<Plant> Plants { get; set; }
        public Dictionary<string,int> Resources { get; set; }
        public ICollection<string> Cities { get; set; }
        //Color should be something other than string
        public string Color { get; set; }
    }
}
