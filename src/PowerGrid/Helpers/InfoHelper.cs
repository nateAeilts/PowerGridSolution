using PowerGrid.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PowerGrid.GameInfo.GameInfo;

namespace PowerGrid.Helpers
{
    public class InfoHelper
    {
        public int NumberOfPlayers;
        public int NumberOfRegions;
        public int NumberOfRemovedPlants;
        public int NumberOfPlayerPlants;
        public int NumberOfCitiesForStep2;
        public int NumberOfCitiesToEnd;
        public string GameEdition;
        public string BoardMap;
        public string CardSet;
        public Dictionary<int, Dictionary<string, int>> ReplenishmentSchedule;
        public Dictionary<int, Models.Plant> PlantCards;

        public InfoHelper(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            NumberOfRegions = GetNumberOfActiveRegions(NumberOfPlayers);
            NumberOfRemovedPlants = GetNumberOfRemovedPlants(NumberOfPlayers);
            NumberOfPlayerPlants = GetNumberOfPlayerPlants(NumberOfPlayers);
            NumberOfCitiesForStep2 = GetNumberOfCitiesForStep2(NumberOfPlayers);
            NumberOfCitiesToEnd = GetNumberOfCitiesToEnd(NumberOfPlayers);

            GameEdition = Constants.Editions.GameEditions.Default;
            BoardMap = Constants.Editions.BoardMap.Default;
            CardSet = Constants.Editions.PlantCards.Default;

            ReplenishmentSchedule = GetReplenishmentSchedule(NumberOfPlayers);
            PlantCards = GetPlants(CardSet);
            //Cities = InfoHelper.GetCities();
        }

        public InfoHelper()
        {
            NumberOfPlayers = 4;
            NumberOfRegions = GetNumberOfActiveRegions(NumberOfPlayers);
            NumberOfRemovedPlants = GetNumberOfRemovedPlants(NumberOfPlayers);
            NumberOfPlayerPlants = GetNumberOfPlayerPlants(NumberOfPlayers);
            NumberOfCitiesForStep2 = GetNumberOfCitiesForStep2(NumberOfPlayers);
            NumberOfCitiesToEnd = GetNumberOfCitiesToEnd(NumberOfPlayers);

            GameEdition = Constants.Editions.GameEditions.Default;
            BoardMap = Constants.Editions.BoardMap.Default;
            CardSet = Constants.Editions.PlantCards.Default;

            ReplenishmentSchedule = GetReplenishmentSchedule(NumberOfPlayers);
            PlantCards = GetPlants(CardSet);
        }

        public Dictionary<string, Models.City> GetCities()
        {
            throw new NotImplementedException();
            //Dictionary<string, Models.City> cities = new Dictionary<string, City>();
            //foreach(string city in Constants.City.Names.ToList())
            //{
            //    Models.City newCity = new City();
                
            //}
        }
    }
}
