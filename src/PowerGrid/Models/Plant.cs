using System;
using System.Collections.Generic;
using System.Text;

namespace PowerGrid.Models
{
    public class Plant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FuelType { get; set; }
        public int FuelCost { get; set; }
        public int BidStart { get; set; }
        public int Power { get; set; }

        public Plant()
        {

        }

        public override string ToString()
        {
            StringBuilder rtnStr = new StringBuilder();
            rtnStr.AppendLine(string.Format("{0}", Name));
            rtnStr.AppendLine(string.Format("    {0}:   {1}", "BidStart", BidStart.ToString()));
            rtnStr.AppendLine(string.Format("    {0}:   {1}", "Resourcetype", FuelType));
            rtnStr.AppendLine(string.Format("    {0}:   {1}", "FuelCost", FuelCost.ToString()));
            rtnStr.AppendLine(string.Format("    {0}:   {1}", "Power", Power.ToString()));

            return rtnStr.ToString();
        }
    }
}