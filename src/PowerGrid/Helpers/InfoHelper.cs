using PowerGrid.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PowerGrid.Helpers
{
    public static class InfoHelper
    {
        public static Dictionary<int, Plant> GetPlants()
        {
            Dictionary<int, Plant> returnPlants = new Dictionary<int, Plant>();
            string plantFilePath = "C:\\Users\\nate.aeilts\\Documents\\Visual Studio 2015\\Projects\\PowerGridSolution\\src\\PowerGrid\\Info\\PlantCards_Original.txt";
            //string plantFilePath = "C:\\Users\\nate.aeilts\\Documents\\Visual Studio 2015\\Projects\\PowerGridSolution\\src\\PowerGrid\\Info\\PlantCards_New.txt";
            string contents = File.ReadAllText(plantFilePath);
            contents = Regex.Replace(contents, @"\t|\n|\r|\ ", "");
            var plants = contents.Split('|');

            Dictionary<string, string> plantProperties = new Dictionary<string, string>();
            for(int i = 0; i < plants.Length -1; i++)
            {
                string plant = TrimOuterStrings(plants[i], "{", "}");
                //Console.WriteLine(plant);

                var props = plant.Split(',');
                StringBuilder pn = new StringBuilder();
                foreach (var prop in props)
                {
                    var pair = prop.Split(':');
                    plantProperties[pair[0]] = pair[1];
                    pn.Append(pair[1] + "-");
                }
                string plantName = pn.ToString().Trim('-');

                Plant newPlant = new Plant();

                int bidStart;
                newPlant.BidStart = GetPlantIntProperty(plantProperties, Constants.Plant.PropertyNames.BidStart, out bidStart);

                int fuelCost;
                newPlant.FuelCost = GetPlantIntProperty(plantProperties, Constants.Plant.PropertyNames.FuelCost, out fuelCost);
                
                int power;
                newPlant.Power = GetPlantIntProperty(plantProperties, Constants.Plant.PropertyNames.Power, out power);

                //Should I use the bid price as the ID? I just don't know.
                newPlant.ID = newPlant.BidStart;
                newPlant.Name = plantName;
                newPlant.FuelType = plantProperties[Constants.Plant.PropertyNames.FuelType];

                plantProperties.Clear();
                returnPlants.Add(newPlant.ID, newPlant);
                //string plantString = newPlant.ToString();
                //Console.WriteLine(plantString);
            }
            return returnPlants;
        }

        public static string TrimOuterStrings(string input, string openingString, string closingString)
        {
            string returnString = input.TrimStart(openingString);
            returnString = returnString.TrimEnd(closingString);

            return returnString;
        }

        public static string TrimStart(this string target, string trimString)
        {
            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }

        public static string TrimEnd(this string target, string trimString)
        {
            string result = target;
            while (result.EndsWith(trimString))
            {
                result = result.Substring(0, result.Length - trimString.Length);
            }

            return result;
        }

        public static int GetPlantIntProperty(Dictionary<string, string> propertyDict, string propertyName, out int propertyInt)
        {
            if (int.TryParse(propertyDict[propertyName], out propertyInt))
            {
                return propertyInt;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
