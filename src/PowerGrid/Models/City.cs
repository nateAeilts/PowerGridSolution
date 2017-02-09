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
        public ICollection<string> Connections { get; set; }

        public City()
        {
            Sections = new Dictionary<string, bool>
            {
                { Constants.City.SectionNames.City10, false },
                { Constants.City.SectionNames.City15, false },
                { Constants.City.SectionNames.City20, false }
            };
        }
    }
}
