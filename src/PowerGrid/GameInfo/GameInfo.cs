using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerGrid.GameInfo
{
    public class GameInfo
    {
        public int NumberOfPlayers;
        public int NumberOfRegions;
        public int NumberOfRemovedPlants;
        public int NumberOfPlayerPlants;
        public int NumberOfCitiesForStep2;
        public int NumberOfCitiesToEnd;
        public Dictionary<int, Dictionary<string, int>> ReplenishmentSchedule;

        #region PayScale
        public readonly Dictionary<int, int> PayScale = new Dictionary<int, int>
        {
            { 0, 10 },
            { 1, 22 },
            { 2, 33 },
            { 3, 44 },
            { 4, 54 },
            { 5, 64 },
            { 6, 73 },
            { 7, 82 },
            { 8, 90 },
            { 9, 98 },
            { 10, 105 },
            { 11, 112 },
            { 12, 118 },
            { 13, 123 },
            { 14, 129 },
            { 15, 134 },
            { 16, 138 },
            { 17, 142 },
            { 18, 145 },
            { 19, 148 },
            { 20, 150 }
        };
        #endregion

        #region TotalFuelTokens
        public Dictionary<string, int> TotalFuelTokens = new Dictionary<string, int>
        {
            { Constants.Fuel.Names.Coal, 24 },
            { Constants.Fuel.Names.Oil, 24 },
            { Constants.Fuel.Names.Garbage, 24 },
            { Constants.Fuel.Names.Uranium, 12 }
        };
        #endregion

        public GameInfo(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            NumberOfRegions = GetNumberOfActiveRegions(NumberOfPlayers);
            NumberOfRemovedPlants = GetNumberOfRemovedPlants(NumberOfPlayers);
            NumberOfPlayerPlants = GetNumberOfPlayerPlants(NumberOfPlayers);
            NumberOfCitiesForStep2 = GetNumberOfCitiesForStep2(NumberOfPlayers);
            NumberOfCitiesToEnd = GetNumberOfCitiesToEnd(NumberOfPlayers);
            ReplenishmentSchedule = GetReplenishmentSchedule(NumberOfPlayers);
        }

        private int GetNumberOfActiveRegions(int numberOfPlayers)
        {
            switch(numberOfPlayers)
            {
                case 2:
                case 3:
                    return 3;
                case 4:
                    return 4;
                case 5:
                case 6:
                    return 5;
                default:
                    throw new Exception();
            }
        }

        private int GetNumberOfRemovedPlants(int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 2:
                case 3:
                    return 8;
                case 4:
                    return 4;
                case 5:
                case 6:
                    return 0;
                default:
                    throw new Exception();
            }
        }

        private int GetNumberOfPlayerPlants(int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 2:
                    return 4;
                case 3:
                case 4:
                case 5:
                case 6:
                    return 3;
                default:
                    throw new Exception();
            }
        }

        private int GetNumberOfCitiesForStep2(int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 2:
                    return 10;
                case 3:
                case 4:
                case 5:
                    return 7;
                case 6:
                    return 6;
                default:
                    throw new Exception();
            }
        }

        private int GetNumberOfCitiesToEnd(int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 2:
                    return 21;
                case 3:
                case 4:
                    return 17;
                case 5:
                    return 15;
                case 6:
                    return 14;
                default:
                    throw new Exception();
            }
        }

        private Dictionary<int, Dictionary<string, int>> GetReplenishmentSchedule(int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 2:
                    return new Dictionary<int, Dictionary<string, int>>
                    {
                        #region 2-Player Replenishment
                        {1, 
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 3 },
                                { Constants.Fuel.Names.Oil, 2 },
                                { Constants.Fuel.Names.Garbage, 1 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        },
                        {2,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 4 },
                                { Constants.Fuel.Names.Oil, 2 },
                                { Constants.Fuel.Names.Garbage, 2 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        },
                        {3,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 3 },
                                { Constants.Fuel.Names.Oil, 4 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        }
                        #endregion
                    };
                case 3:
                    return new Dictionary<int, Dictionary<string, int>>
                    {
                        #region 3-Player Replenishment
                        {1,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 4 },
                                { Constants.Fuel.Names.Oil, 2 },
                                { Constants.Fuel.Names.Garbage, 1 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        },
                        {2,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 5 },
                                { Constants.Fuel.Names.Oil, 3 },
                                { Constants.Fuel.Names.Garbage, 2 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        },
                        {3,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 3 },
                                { Constants.Fuel.Names.Oil, 4 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        }
                        #endregion
                    };
                case 4:
                    return new Dictionary<int, Dictionary<string, int>>
                    {
                        #region 4-Player Replenishment
                        {1,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 5 },
                                { Constants.Fuel.Names.Oil, 3 },
                                { Constants.Fuel.Names.Garbage, 2 },
                                { Constants.Fuel.Names.Uranium, 1 }
                            }
                        },
                        {2,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 6 },
                                { Constants.Fuel.Names.Oil, 4 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 2 }
                            }
                        },
                        {3,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 4 },
                                { Constants.Fuel.Names.Oil, 5 },
                                { Constants.Fuel.Names.Garbage, 4 },
                                { Constants.Fuel.Names.Uranium, 2 }
                            }
                        }
                        #endregion
                    };
                case 5:
                    return new Dictionary<int, Dictionary<string, int>>
                    {
                        #region 5-Player Replenishment
                        {1,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 5 },
                                { Constants.Fuel.Names.Oil, 4 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 2 }
                            }
                        },
                        {2,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 7 },
                                { Constants.Fuel.Names.Oil, 5 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 3 }
                            }
                        },
                        {3,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 5 },
                                { Constants.Fuel.Names.Oil, 6 },
                                { Constants.Fuel.Names.Garbage, 5 },
                                { Constants.Fuel.Names.Uranium, 2 }
                            }
                        }
                        #endregion
                    };
                case 6:
                    return new Dictionary<int, Dictionary<string, int>>
                    {
                        #region 6-Player Replenishment
                        {1,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 7 },
                                { Constants.Fuel.Names.Oil, 5 },
                                { Constants.Fuel.Names.Garbage, 3 },
                                { Constants.Fuel.Names.Uranium, 2 }
                            }
                        },
                        {2,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 9 },
                                { Constants.Fuel.Names.Oil, 6 },
                                { Constants.Fuel.Names.Garbage, 5 },
                                { Constants.Fuel.Names.Uranium, 3 }
                            }
                        },
                        {3,
                            new Dictionary<string, int>
                            {
                                { Constants.Fuel.Names.Coal, 6 },
                                { Constants.Fuel.Names.Oil, 7 },
                                { Constants.Fuel.Names.Garbage, 6 },
                                { Constants.Fuel.Names.Uranium, 3 }
                            }
                        }
                        #endregion
                    };
                default:
                    throw new Exception();
            }
        }
    }
}
