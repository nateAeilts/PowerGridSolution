using PowerGrid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PowerGrid.Models;
using static PowerGrid.Constants.Connections.Names;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace PowerGrid.GameInfo
{
    public static class GameInfo
    {
        #region City dictionary<string cityName, Models.City>
        public static Dictionary<string, Models.City> Cities = new Dictionary<string, Models.City>
        {
            #region Atlanta
            { Constants.City.Names.Atlanta,
                new Models.City
                {
                    ID = 1,
                    Name = Constants.City.Names.Atlanta,
                    Connections = new string[]
                    {
                        AtlantaRaleigh,
                        AtlantaSavannah,
                        BirminghamAtlanta,
                        StLouisAtlanta,
                        KnoxvilleAtlanta
                    }
                }
            },
            #endregion
            #region Billings
            { Constants.City.Names.Billings,
                new Models.City
                {
                    ID = 2,
                    Name = Constants.City.Names.Billings,
                    Connections = new string[]
                    {
                        BillingsCheyenne,
                        BillingsFargo,
                        BillingsMinneapolis,
                        SeattleBillings,
                        BoiseBillings
                    }
                }
            },
            #endregion
            #region Birmingham
            { Constants.City.Names.Birmingham,
                new Models.City
                {
                    ID = 3,
                    Name = Constants.City.Names.Birmingham,
                    Connections = new string[]
                    {
                        BirminghamAtlanta,
                        BirminghamJacksonville,
                        NewOrleansBirmingham,
                        MemphisBirmingham
                    }
                }
            },
            #endregion
            #region Boise
            { Constants.City.Names.Boise,
                new Models.City
                {
                    ID = 4,
                    Name = Constants.City.Names.Boise,
                    Connections = new string[]
                    {
                        BoiseBillings,
                        BoiseCheyenne,
                        BoiseSaltLakeCity,
                        SeattleBoise,
                        PortlandBoise,
                        SanFranciscoBoise
                    }
                }
            },
            #endregion
            #region Boston
            { Constants.City.Names.Boston,
                new Models.City
                {
                    ID = 5,
                    Name = Constants.City.Names.Boston,
                    Connections = new string[]
                    {
                        NewYorkBoston
                    }
                }
            },
            #endregion
            #region Buffalo
            { Constants.City.Names.Buffalo,
                new Models.City
                {
                    ID = 6,
                    Name = Constants.City.Names.Buffalo,
                    Connections = new string[]
                    {
                        BuffaloNewYork,
                        DetroitBuffalo,
                        PittsburghBuffalo
                    }
                }
            },
            #endregion
            #region Cheyenne
            { Constants.City.Names.Cheyenne,
                new Models.City
                {
                    ID = 7,
                    Name = Constants.City.Names.Cheyenne,
                    Connections = new string[]
                    {
                        CheyenneMinneapolis,
                        CheyenneOmaha,
                        DenverCheyenne,
                        BoiseCheyenne,
                        BillingsCheyenne
                    }
                }
            },
            #endregion
            #region Chicago
            { Constants.City.Names.Chicago,
                new Models.City
                {
                    ID = 8,
                    Name = Constants.City.Names.Chicago,
                    Connections = new string[]
                    {
                        ChicagoCincinnati,
                        ChicagoDetroit,
                        DuluthChicago,
                        MinneapolisChicago,
                        OmahaChicago,
                        KansasCityChicago,
                        StLouisChicago
                    }
                }
            },
            #endregion
            #region Cincinnati
            { Constants.City.Names.Cincinnati,
                new Models.City
                {
                    ID = 9,
                    Name = Constants.City.Names.Cincinnati,
                    Connections = new string[]
                    {
                        CincinnatiDetroit,
                        CincinnatiPittsburgh,
                        CincinnatiRaleigh,
                        CincinnatiKnoxville,
                        StLouisCincinnati,
                        ChicagoCincinnati
                    }
                }
            },
            #endregion
            #region Dallas
            { Constants.City.Names.Dallas,
                new Models.City
                {
                    ID = 10,
                    Name = Constants.City.Names.Dallas,
                    Connections = new string[]
                    {
                        DallasHouston,
                        DallasNewOrleans,
                        DallasMemphis,
                        OklahomaCityDallas,
                        SantaFeDallas
                    }
                }
            },
            #endregion

            
            #region Denver
            { Constants.City.Names.Denver,
                new Models.City
                {
                    ID = 11,
                    Name = Constants.City.Names.Denver,
                    Connections = new string[]
                    {
                        SaltLakeCityDenver,
                        SantaFeDenver,
                        DenverCheyenne,
                        DenverKansasCity
                    }
                }
            },
            #endregion
            #region Detroit
            { Constants.City.Names.Detroit,
                new Models.City
                {
                    ID = 12,
                    Name = Constants.City.Names.Detroit,
                    Connections = new string[]
                    {
                        DuluthDetroit,
                        ChicagoDetroit,
                        CincinnatiDetroit,
                        DetroitBuffalo,
                        DetroitPittsburgh
                    }
                }
            },
            #endregion
            #region Duluth
            { Constants.City.Names.Duluth,
                new Models.City
                {
                    ID = 13,
                    Name = Constants.City.Names.Duluth,
                    Connections = new string[]
                    {
                        FargoDuluth,
                        MinneapolisDuluth,
                        DuluthDetroit,
                        DuluthChicago
                    }
                }
            },
            #endregion
            #region Fargo
            { Constants.City.Names.Fargo,
                new Models.City
                {
                    ID = 14,
                    Name = Constants.City.Names.Fargo,
                    Connections = new string[]
                    {
                        BillingsFargo,
                        FargoDuluth,
                        FargoMinneapolis
                    }
                }
            },
            #endregion
            #region Houston
            { Constants.City.Names.Houston,
                new Models.City
                {
                    ID = 15,
                    Name = Constants.City.Names.Houston,
                    Connections = new string[]
                    {
                        SantaFeHouston,
                        DallasHouston,
                        DallasNewOrleans,
                        DallasMemphis
                    }
                }
            },
            #endregion
            #region Jacksonville
            { Constants.City.Names.Jacksonville,
                new Models.City
                {
                    ID = 16,
                    Name = Constants.City.Names.Jacksonville,
                    Connections = new string[]
                    {
                        NewOrleansJacksonville,
                        BirminghamJacksonville,
                        TampaJacksonville,
                        JacksonvilleSavannah
                    }
                }
            },
            #endregion
            #region KansasCity
            { Constants.City.Names.KansasCity,
                new Models.City
                {
                    ID = 17,
                    Name = Constants.City.Names.KansasCity,
                    Connections = new string[]
                    {
                        DenverKansasCity,
                        SantaFeKansasCity,
                        OklahomaCityKansasCity,
                        OmahaKansasCity,
                        KansasCityChicago,
                        KansasCityStLouis,
                        KansasCityMemphis
                    }
                }
            },
            #endregion
            #region Knoxville
            { Constants.City.Names.Knoxville,
                new Models.City
                {
                    ID = 18,
                    Name = Constants.City.Names.Knoxville,
                    Connections = new string[]
                    {
                        CincinnatiKnoxville,
                        KnoxvilleAtlanta
                    }
                }
            },
            #endregion
            #region LasVegas
            { Constants.City.Names.LasVegas,
                new Models.City
                {
                    ID = 19,
                    Name = Constants.City.Names.LasVegas,
                    Connections = new string[]
                    {
                        SanFranciscoLasVegas,
                        LosAngelesLasVegas,
                        SanDiegoLasVegas,
                        LasVegasSaltLakeCity,
                        LasVegasSantaFe,
                        LasVegasPhoenix
                    }
                }
            },
            #endregion
            #region LosAngeles
            { Constants.City.Names.LosAngeles,
                new Models.City
                {
                    ID = 20,
                    Name = Constants.City.Names.LosAngeles,
                    Connections = new string[]
                    {
                        SanFranciscoLosAngeles,
                        LosAngelesLasVegas,
                        LosAngelesSanDiego
                    }
                }
            },
            #endregion

            
            #region Memphis
            { Constants.City.Names.Memphis,
                new Models.City
                {
                    ID = 21,
                    Name = Constants.City.Names.Memphis,
                    Connections = new string[]
                    {
                        StLouisMemphis,
                        KansasCityMemphis,
                        OklahomaCityMemphis,
                        DallasMemphis,
                        MemphisNewOrleans,
                        MemphisBirmingham
                    }
                }
            },
            #endregion
            #region Miami
            { Constants.City.Names.Miami,
                new Models.City
                {
                    ID = 22,
                    Name = Constants.City.Names.Miami,
                    Connections = new string[]
                    {
                        TampaMiami
                    }
                }
            },
            #endregion
            #region Minneapolis
            { Constants.City.Names.Minneapolis,
                new Models.City
                {
                    ID = 23,
                    Name = Constants.City.Names.Minneapolis,
                    Connections = new string[]
                    {
                        FargoMinneapolis,
                        BillingsMinneapolis,
                        CheyenneMinneapolis,
                        OmahaMinneapolis,
                        MinneapolisDuluth,
                        MinneapolisChicago
                    }
                }
            },
            #endregion
            #region NewOrleans
            { Constants.City.Names.NewOrleans,
                new Models.City
                {
                    ID = 24,
                    Name = Constants.City.Names.NewOrleans,
                    Connections = new string[]
                    {
                        MemphisNewOrleans,
                        DallasNewOrleans,
                        HoustonNewOrleans,
                        NewOrleansBirmingham,
                        NewOrleansJacksonville
                    }
                }
            },
            #endregion
            #region NewYork
            { Constants.City.Names.NewYork,
                new Models.City
                {
                    ID = 25,
                    Name = Constants.City.Names.NewYork,
                    Connections = new string[]
                    {
                        BuffaloNewYork,
                        PhiladelphiaNewYork,
                        NewYorkBoston
                    }
                }
            },
            #endregion
            #region Norfolk
            { Constants.City.Names.Norfolk,
                new Models.City
                {
                    ID = 26,
                    Name = Constants.City.Names.Norfolk,
                    Connections = new string[]
                    {
                        WashingtonNorfolk,
                        RaleighNorfolk
                    }
                }
            },
            #endregion
            #region OklahomaCity
            { Constants.City.Names.OklahomaCity,
                new Models.City
                {
                    ID = 27,
                    Name = Constants.City.Names.OklahomaCity,
                    Connections = new string[]
                    {
                        SantaFeOklahomaCity,
                        OklahomaCityKansasCity,
                        OklahomaCityMemphis,
                        OklahomaCityDallas
                    }
                }
            },
            #endregion
            #region Omaha
            { Constants.City.Names.Omaha,
                new Models.City
                {
                    ID = 28,
                    Name = Constants.City.Names.Omaha,
                    Connections = new string[]
                    {
                        CheyenneOmaha,
                        OmahaMinneapolis,
                        OmahaChicago,
                        OmahaKansasCity
                    }
                }
            },
            #endregion
            #region Philadelphia
            { Constants.City.Names.Philadelphia,
                new Models.City
                {
                    ID = 29,
                    Name = Constants.City.Names.Philadelphia,
                    Connections = new string[]
                    {
                        WashingtonPhiladelphia,
                        PhiladelphiaNewYork
                    }
                }
            },
            #endregion
            #region Phoenix
            { Constants.City.Names.Phoenix,
                new Models.City
                {
                    ID = 30,
                    Name = Constants.City.Names.Phoenix,
                    Connections = new string[]
                    {
                        LasVegasPhoenix,
                        SanDiegoPhoenix,
                        PhoenixSantaFe
                    }
                }
            },
            #endregion

            
            #region Pittsburgh
            { Constants.City.Names.Pittsburgh,
                new Models.City
                {
                    ID = 31,
                    Name = Constants.City.Names.Pittsburgh,
                    Connections = new string[]
                    {
                        DetroitPittsburgh,
                        CincinnatiPittsburgh,
                        PittsburghBuffalo,
                        PittsburghWashington,
                        PittsburghRaleigh
                    }
                }
            },
            #endregion
            #region Portland
            { Constants.City.Names.Portland,
                new Models.City
                {
                    ID = 32,
                    Name = Constants.City.Names.Portland,
                    Connections = new string[]
                    {
                        SanFranciscoPortland,
                        PortlandSeattle,
                        PortlandBoise
                    }
                }
            },
            #endregion
            #region Raleigh
            { Constants.City.Names.Raleigh,
                new Models.City
                {
                    ID = 33,
                    Name = Constants.City.Names.Raleigh,
                    Connections = new string[]
                    {
                        PittsburghRaleigh,
                        CincinnatiRaleigh,
                        AtlantaRaleigh,
                        SavannahRaleigh,
                        RaleighNorfolk
                    }
                }
            },
            #endregion
            #region SaltLakeCity
            { Constants.City.Names.SaltLakeCity,
                new Models.City
                {
                    ID = 34,
                    Name = Constants.City.Names.SaltLakeCity,
                    Connections = new string[]
                    {
                        BoiseSaltLakeCity,
                        SanFranciscoSaltLakeCity,
                        LasVegasSaltLakeCity,
                        SaltLakeCityDenver,
                        SaltLakeCitySantaFe
                    }
                }
            },
            #endregion
            #region SanDiego
            { Constants.City.Names.SanDiego,
                new Models.City
                {
                    ID = 35,
                    Name = Constants.City.Names.SanDiego,
                    Connections = new string[]
                    {
                        LosAngelesSanDiego,
                        SanDiegoLasVegas,
                        SanDiegoPhoenix
                    }
                }
            },
            #endregion
            #region SanFrancisco
            { Constants.City.Names.SanFrancisco,
                new Models.City
                {
                    ID = 36,
                    Name = Constants.City.Names.SanFrancisco,
                    Connections = new string[]
                    {
                        SanFranciscoPortland,
                        SanFranciscoBoise,
                        SanFranciscoSaltLakeCity,
                        SanFranciscoLasVegas,
                        SanFranciscoLosAngeles
                    }
                }
            },
            #endregion
            #region SantaFe
            { Constants.City.Names.SantaFe,
                new Models.City
                {
                    ID = 37,
                    Name = Constants.City.Names.SantaFe,
                    Connections = new string[]
                    {
                        PhoenixSantaFe,
                        LasVegasSantaFe,
                        SaltLakeCitySantaFe,
                        SantaFeDenver,
                        SantaFeKansasCity,
                        SantaFeOklahomaCity,
                        SantaFeDallas,
                        SantaFeHouston
                    }
                }
            },
            #endregion
            #region Savannah
            { Constants.City.Names.Savannah,
                new Models.City
                {
                    ID = 38,
                    Name = Constants.City.Names.Savannah,
                    Connections = new string[]
                    {
                        AtlantaSavannah,
                        JacksonvilleSavannah,
                        SavannahRaleigh
                    }
                }
            },
            #endregion
            #region Seattle
            { Constants.City.Names.Seattle,
                new Models.City
                {
                    ID = 39,
                    Name = Constants.City.Names.Seattle,
                    Connections = new string[]
                    {
                        PortlandSeattle,
                        SeattleBoise,
                        SeattleBillings
                    }
                }
            },
            #endregion
            #region StLouis
            { Constants.City.Names.StLouis,
                new Models.City
                {
                    ID = 40,
                    Name = Constants.City.Names.StLouis,
                    Connections = new string[]
                    {
                        KansasCityStLouis,
                        StLouisChicago,
                        StLouisCincinnati,
                        StLouisAtlanta,
                        StLouisMemphis
                    }
                }
            },
            #endregion

            
            #region Tampa
            { Constants.City.Names.Tampa,
                new Models.City
                {
                    ID = 41,
                    Name = Constants.City.Names.Tampa,
                    Connections = new string[]
                    {
                        TampaJacksonville,
                        TampaMiami
                    }
                }
            },
            #endregion
            #region Washington
            { Constants.City.Names.Washington,
                new Models.City
                {
                    ID = 42,
                    Name = Constants.City.Names.Washington,
                    Connections = new string[]
                    {
                        PittsburghWashington,
                        WashingtonPhiladelphia,
                        WashingtonNorfolk
                    }
                }
            },
            #endregion
        };
        #endregion

        #region PayScale Dictionary<int,int>
        public static Dictionary<int, int> PayScale = new Dictionary<int, int>
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

        #region TotalFuelTokens dictionary <string fuelName, int>
        public static Dictionary<string, int> TotalFuelTokens = new Dictionary<string, int>
        {
            { Constants.Fuel.Names.Coal, 24 },
            { Constants.Fuel.Names.Oil, 24 },
            { Constants.Fuel.Names.Garbage, 24 },
            { Constants.Fuel.Names.Uranium, 12 }
        };
        #endregion

        public static int GetNumberOfActiveRegions(int numberOfPlayers)
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

        public static int GetNumberOfRemovedPlants(int numberOfPlayers)
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

        public static int GetNumberOfPlayerPlants(int numberOfPlayers)
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

        public static int GetNumberOfCitiesForStep2(int numberOfPlayers)
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

        public static int GetNumberOfCitiesToEnd(int numberOfPlayers)
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

        public static Dictionary<int, Dictionary<string, int>> GetReplenishmentSchedule(int numberOfPlayers)
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

        public static int GetPlantIntProperty(Dictionary<string, string> propertyDict, string propertyName, out int propertyInt)
        {
            //I don't remember why I bothered with this method
            if (int.TryParse(propertyDict[propertyName], out propertyInt))
            {
                return propertyInt;
            }
            else
            {
                throw new Exception();
            }
        }

        public static Dictionary<int, Plant> GetPlants(string cardSet)
        {
            Dictionary<int, Plant> returnPlants = new Dictionary<int, Plant>();
            string plantFilePath;
            switch (cardSet)
            {
                case Constants.Editions.PlantCards.Original:
                    plantFilePath = "C:\\Users\\nate.aeilts\\Documents\\Visual Studio 2015\\Projects\\PowerGridSolution\\src\\PowerGrid\\Info\\PlantCards_Original.txt";
                    break;
                case Constants.Editions.PlantCards.New:
                    plantFilePath = "C:\\Users\\nate.aeilts\\Documents\\Visual Studio 2015\\Projects\\PowerGridSolution\\src\\PowerGrid\\Info\\PlantCards_New.txt";
                    break;
                default:
                    throw new Exception();
            }

            //
            string contents = File.ReadAllText(plantFilePath);
            contents = Regex.Replace(contents, @"\t|\n|\r|\ ", "");
            var plants = contents.Split('|');

            Dictionary<string, string> plantProperties = new Dictionary<string, string>();
            for (int i = 0; i < plants.Length - 1; i++)
            {
                string plant = StringHelper.TrimOuterStrings(plants[i], "{", "}");
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
    }
}
