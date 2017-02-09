using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PowerGrid
{
    public static class Constants
    {
        public static class Player
        {
            public static class PropertyNames
            {
                public static string ID = "ID";
                public static string GameID = "GameID";
                public static string Name = "Name";
                public static string Money = "Money";
                public static string Houses = "Houses";
                public static string Plants = "Plants";
                public static string Resources = "Resources";
                public static string Cities = "Cities";
                public static string Color = "Color";
            }

            public static class Colors
            {
                //Red
                //Blue
                //Yellow
                //Purple
                //Green
                //Black
            }
        }

        public static class Plant
        {
            public static class PropertyNames
            {
                public static string Name = "Name";
                public static string BidStart = "BidStart";
                public static string FuelType = "ResourceType";
                public static string FuelCost = "FuelCost";
                public static string Power = "Power";
            }
        }

        public static class Fuel
        {
            public static class Names
            {
                public static string Coal = "Coal";
                public static string Oil = "Oil";
                public static string CoalOil = "CoalOil";
                public static string Garbage = "Garbage";
                public static string Uranium = "Uranium";
                public static string Green = "Green";
            }
        }

        public static class Region
        {
            public static class Names
            {
                public static string Northwest = "Northwest";
                public static string Southwest = "Southwest";
                public static string South = "South";
                public static string Southeast = "Southeast";
                public static string Northeast = "Northeast";
                public static string Midwest = "Midwest";
            }

            public static class Borders
            {
                public static string NorthwestSouthwest = Names.Northwest + "-" + Names.Southwest;
                public static string NorthwestMidwest = Names.Northwest + "-" + Names.Midwest;
                public static string NorthwestSouth = Names.Northwest + "-" + Names.South;
                public static string SouthwestSouth = Names.Southwest + "-" + Names.South;
                public static string MidwestSouth = Names.Midwest + "-" + Names.South;
                public static string MidwestSoutheast = Names.Midwest + "-" + Names.Southeast;
                public static string MidwestNortheast = Names.Midwest + "-" + Names.Northeast;
                public static string SouthSoutheast = Names.South + "-" + Names.Southeast;
                public static string NortheastSoutheast = Names.Northeast + "-" + Names.Southeast;
            }
        }

        public static class City
        {
            public static class SectionNames
            {
                public static string City10 = "City10";
                public static string City15 = "City15";
                public static string City20 = "City20";
            }

            public static class Names
            {
                public static string Atlanta = "Atlanta";
                public static string Billings = "Billings";
                public static string Birmingham = "Birmingham";
                public static string Boise = "Boise";
                public static string Boston = "Boston";
                public static string Buffalo = "Buffalo";
                public static string Cheyenne = "Cheyenne";
                public static string Chicago = "Chicago";
                public static string Cincinnati = "Cincinnati";
                public static string Dallas = "Dallas";

                public static string Denver = "Denver";
                public static string Detroit = "Detroit";
                public static string Duluth = "Duluth";
                public static string Fargo = "Fargo";
                public static string Houston = "Houston";
                public static string Jacksonville = "Jacksonville";
                public static string KansasCity = "KansasCity";
                public static string Knoxville = "Knoxville";
                public static string LasVegas = "LasVegas";
                public static string LosAngeles = "LosAngeles";

                public static string Memphis = "Memphis";
                public static string Miami = "Miami";
                public static string Minneapolis = "Minneapolis";
                public static string NewOrleans = "NewOrleans";
                public static string NewYork = "NewYork";
                public static string Norfolk = "Norfolk";
                public static string OklahomaCity = "OklahomaCity";
                public static string Omaha = "Omaha";
                public static string Philadelphia = "Philadelphia";
                public static string Phoenix = "Phoenix";

                public static string Pittsburgh = "Pittsburgh";
                public static string Portland = "Portland";
                public static string Raleigh = "Raleigh";
                public static string SaltLakeCity = "SaltLakeCity";
                public static string SanDiego = "SanDiego";
                public static string SanFrancisco = "SanFrancisco";
                public static string SantaFe = "SantaFe";
                public static string Savannah = "Savannah";
                public static string Seattle = "Seattle";
                public static string StLouis = "StLouis";

                public static string Tampa = "Tampa";
                public static string Washington = "Washington";

                public static List<string> ToList()
                {
                    List<string> cities = new List<string>();
                    Type type = typeof(Names);
                    foreach (var p in type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic))
                    {
                        var v = p.GetValue(null);
                        cities.Add(v.ToString());
                    }
                    return cities;
                }
            }

            #region regional dictionary
            public static readonly Dictionary<string, string[]> ByRegion = new Dictionary<string, string[]>
            {
                {Region.Names.Northwest, new string[]
                    {
                        Names.Seattle,
                        Names.Portland,
                        Names.Boise,
                        Names.Billings,
                        Names.Cheyenne,
                        Names.Denver,
                        Names.Omaha
                    }
                },
                {Region.Names.Southwest, new string[]
                    {
                        Names.SanFrancisco,
                        Names.LosAngeles,
                        Names.SanDiego,
                        Names.LasVegas,
                        Names.SaltLakeCity,
                        Names.SantaFe,
                        Names.Phoenix
                    }
                },
                {Region.Names.South, new string[]
                    {
                        Names.KansasCity,
                        Names.OklahomaCity,
                        Names.Dallas,
                        Names.Houston,
                        Names.Memphis,
                        Names.NewOrleans,
                        Names.Birmingham
                    }
                },
                {Region.Names.Southeast, new string[]
                    {
                        Names.Atlanta,
                        Names.Norfolk,
                        Names.Raleigh,
                        Names.Savannah,
                        Names.Jacksonville,
                        Names.Tampa,
                        Names.Miami
                    }
                },
                {Region.Names.Northeast, new string[]
                    {
                        Names.Boston,
                        Names.NewYork,
                        Names.Philadelphia,
                        Names.Washington,
                        Names.Pittsburgh,
                        Names.Buffalo,
                        Names.Detroit
                    }
                },
                {Region.Names.Midwest, new string[]
                    {
                        Names.Fargo,
                        Names.Duluth,
                        Names.Minneapolis,
                        Names.Chicago,
                        Names.StLouis,
                        Names.Cincinnati,
                        Names.Knoxville
                    }
                }
            };
            #endregion
        }

        public static class Connections
        {
            public static class Names
            {
                public static string PortlandSeattle = City.Names.Portland + "-" + City.Names.Seattle;
                public static string PortlandBoise = City.Names.Portland + "-" + City.Names.Boise;

                public static string SanFranciscoPortland = City.Names.SanFrancisco + "-" + City.Names.Portland;
                public static string SanFranciscoBoise = City.Names.SanFrancisco + "-" + City.Names.Boise;
                public static string SanFranciscoSaltLakeCity = City.Names.SanFrancisco + "-" + City.Names.SaltLakeCity;
                public static string SanFranciscoLasVegas = City.Names.SanFrancisco + "-" + City.Names.LasVegas;
                public static string SanFranciscoLosAngeles = City.Names.SanFrancisco + "-" + City.Names.LosAngeles;

                public static string LosAngelesLasVegas = City.Names.LosAngeles + "-" + City.Names.LasVegas;
                public static string LosAngelesSanDiego = City.Names.LosAngeles + "-" + City.Names.SanDiego;

                public static string SanDiegoLasVegas = City.Names.SanDiego + "-" + City.Names.LasVegas;
                public static string SanDiegoPhoenix = City.Names.SanDiego + "-" + City.Names.Phoenix;

                public static string SeattleBoise = City.Names.Seattle + "-" + City.Names.Boise;
                public static string SeattleBillings = City.Names.Seattle + "-" + City.Names.Billings;

                public static string BoiseBillings = City.Names.Boise + "-" + City.Names.Billings;
                public static string BoiseCheyenne = City.Names.Boise + "-" + City.Names.Cheyenne;
                public static string BoiseSaltLakeCity = City.Names.Boise + "-" + City.Names.SaltLakeCity;

                public static string LasVegasSaltLakeCity = City.Names.LasVegas + "-" + City.Names.SaltLakeCity;
                public static string LasVegasSantaFe = City.Names.LasVegas + "-" + City.Names.SantaFe;
                public static string LasVegasPhoenix = City.Names.LasVegas + "-" + City.Names.Phoenix;

                public static string PhoenixSantaFe = City.Names.Phoenix + "-" + City.Names.SantaFe;

                public static string SaltLakeCityDenver = City.Names.SaltLakeCity + "-" + City.Names.Denver;
                public static string SaltLakeCitySantaFe = City.Names.SaltLakeCity + "-" + City.Names.SantaFe;

                public static string BillingsFargo = City.Names.Billings + "-" + City.Names.Fargo;
                public static string BillingsMinneapolis = City.Names.Billings + "-" + City.Names.Minneapolis;
                public static string BillingsCheyenne = City.Names.Billings + "-" + City.Names.Cheyenne;

                public static string CheyenneMinneapolis = City.Names.Cheyenne + "-" + City.Names.Minneapolis;
                public static string CheyenneOmaha = City.Names.Cheyenne + "-" + City.Names.Omaha;

                public static string DenverCheyenne = City.Names.Denver + "-" + City.Names.Cheyenne;
                public static string DenverKansasCity = City.Names.Denver + "-" + City.Names.KansasCity;

                public static string SantaFeDenver = City.Names.SantaFe + "-" + City.Names.Denver;
                public static string SantaFeKansasCity = City.Names.SantaFe + "-" + City.Names.KansasCity;
                public static string SantaFeOklahomaCity = City.Names.SantaFe + "-" + City.Names.OklahomaCity;
                public static string SantaFeDallas = City.Names.SantaFe + "-" + City.Names.Dallas;
                public static string SantaFeHouston = City.Names.SantaFe + "-" + City.Names.Houston;

                public static string FargoDuluth = City.Names.Fargo + "-" + City.Names.Duluth;
                public static string FargoMinneapolis = City.Names.Fargo + "-" + City.Names.Minneapolis;

                public static string DuluthDetroit = City.Names.Duluth + "-" + City.Names.Detroit;
                public static string DuluthChicago = City.Names.Duluth + "-" + City.Names.Chicago;

                public static string MinneapolisDuluth = City.Names.Minneapolis + "-" + City.Names.Duluth;
                public static string MinneapolisChicago = City.Names.Minneapolis + "-" + City.Names.Chicago;

                public static string OmahaMinneapolis = City.Names.Omaha + "-" + City.Names.Minneapolis;
                public static string OmahaChicago = City.Names.Omaha + "-" + City.Names.Chicago;
                public static string OmahaKansasCity = City.Names.Omaha + "-" + City.Names.KansasCity;

                public static string KansasCityChicago = City.Names.KansasCity + "-" + City.Names.Chicago;
                public static string KansasCityStLouis = City.Names.KansasCity + "-" + City.Names.StLouis;
                public static string KansasCityMemphis = City.Names.KansasCity + "-" + City.Names.Memphis;

                public static string OklahomaCityKansasCity = City.Names.OklahomaCity + "-" + City.Names.KansasCity;
                public static string OklahomaCityMemphis = City.Names.OklahomaCity + "-" + City.Names.Memphis;
                public static string OklahomaCityDallas = City.Names.OklahomaCity + "-" + City.Names.Dallas;

                public static string DallasMemphis = City.Names.Dallas + "-" + City.Names.Memphis;
                public static string DallasNewOrleans = City.Names.Dallas + "-" + City.Names.NewOrleans;
                public static string DallasHouston = City.Names.Dallas + "-" + City.Names.Houston;

                public static string HoustonNewOrleans = City.Names.Houston + "-" + City.Names.NewOrleans;

                public static string ChicagoDetroit = City.Names.Chicago + "-" + City.Names.Detroit;
                public static string ChicagoCincinnati = City.Names.Chicago + "-" + City.Names.Cincinnati;

                public static string StLouisChicago = City.Names.StLouis + "-" + City.Names.Chicago;
                public static string StLouisCincinnati = City.Names.StLouis + "-" + City.Names.Cincinnati;
                public static string StLouisAtlanta = City.Names.StLouis + "-" + City.Names.Atlanta;
                public static string StLouisMemphis = City.Names.StLouis + "-" + City.Names.Memphis;

                public static string MemphisBirmingham = City.Names.Memphis + "-" + City.Names.Birmingham;
                public static string MemphisNewOrleans = City.Names.Memphis + "-" + City.Names.NewOrleans;

                public static string NewOrleansBirmingham = City.Names.NewOrleans + "-" + City.Names.Birmingham;
                public static string NewOrleansJacksonville = City.Names.NewOrleans + "-" + City.Names.Jacksonville;

                public static string BirminghamAtlanta = City.Names.Birmingham + "-" + City.Names.Atlanta;
                public static string BirminghamJacksonville = City.Names.Birmingham + "-" + City.Names.Jacksonville;

                public static string DetroitBuffalo = City.Names.Detroit + "-" + City.Names.Buffalo;
                public static string DetroitPittsburgh = City.Names.Detroit + "-" + City.Names.Pittsburgh;

                public static string CincinnatiDetroit = City.Names.Cincinnati + "-" + City.Names.Detroit;
                public static string CincinnatiPittsburgh = City.Names.Cincinnati + "-" + City.Names.Pittsburgh;
                public static string CincinnatiRaleigh = City.Names.Cincinnati + "-" + City.Names.Raleigh;
                public static string CincinnatiKnoxville = City.Names.Cincinnati + "-" + City.Names.Knoxville;

                public static string KnoxvilleAtlanta = City.Names.Knoxville + "-" + City.Names.Atlanta;

                public static string AtlantaRaleigh = City.Names.Atlanta + "-" + City.Names.Raleigh;
                public static string AtlantaSavannah = City.Names.Atlanta + "-" + City.Names.Savannah;

                public static string PittsburghBuffalo = City.Names.Pittsburgh + "-" + City.Names.Buffalo;
                public static string PittsburghWashington = City.Names.Pittsburgh + "-" + City.Names.Washington;
                public static string PittsburghRaleigh = City.Names.Pittsburgh + "-" + City.Names.Raleigh;

                public static string BuffaloNewYork = City.Names.Buffalo + "-" + City.Names.NewYork;

                public static string NewYorkBoston = City.Names.NewYork + "-" + City.Names.Boston;

                public static string PhiladelphiaNewYork = City.Names.Philadelphia + "-" + City.Names.NewYork;

                public static string WashingtonPhiladelphia = City.Names.Washington + "-" + City.Names.Philadelphia;
                public static string WashingtonNorfolk = City.Names.Washington + "-" + City.Names.Norfolk;

                public static string RaleighNorfolk = City.Names.Raleigh + "-" + City.Names.Norfolk;

                public static string SavannahRaleigh = City.Names.Savannah + "-" + City.Names.Raleigh;

                public static string JacksonvilleSavannah = City.Names.Jacksonville + "-" + City.Names.Savannah;

                public static string TampaJacksonville = City.Names.Tampa + "-" + City.Names.Jacksonville;
                public static string TampaMiami = City.Names.Tampa + "-" + City.Names.Miami;
            }

            #region regional dictionary
            public static readonly Dictionary<string, string[]> ByRegion = new Dictionary<string, string[]>
            {
                {Region.Names.Northwest, new string[]
                    {
                        Names.PortlandSeattle,
                        Names.PortlandBoise,
                        Names.SeattleBillings,
                        Names.SeattleBoise,
                        Names.BoiseBillings,
                        Names.BoiseCheyenne,
                        Names.CheyenneOmaha,
                        Names.DenverCheyenne
                    }
                },
                {Region.Names.Southwest, new string[]
                    {
                        Names.SanFranciscoSaltLakeCity,
                        Names.SanFranciscoLasVegas,
                        Names.SanFranciscoLosAngeles,
                        Names.LosAngelesLasVegas,
                        Names.LosAngelesSanDiego,
                        Names.SanDiegoLasVegas,
                        Names.SanDiegoPhoenix,
                        Names.LasVegasSaltLakeCity,
                        Names.LasVegasSantaFe,
                        Names.LasVegasPhoenix,
                        Names.SaltLakeCitySantaFe,
                        Names.PhoenixSantaFe
                    }
                },
                {Region.Names.South, new string[]
                    {
                        Names.KansasCityMemphis,
                        Names.OklahomaCityKansasCity,
                        Names.OklahomaCityMemphis,
                        Names.OklahomaCityDallas,
                        Names.DallasMemphis,
                        Names.DallasNewOrleans,
                        Names.DallasHouston,
                        Names.HoustonNewOrleans,
                        Names.MemphisBirmingham,
                        Names.MemphisNewOrleans,
                        Names.NewOrleansBirmingham
                    }
                },
                {Region.Names.Southeast, new string[]
                    {
                        Names.AtlantaRaleigh,
                        Names.AtlantaSavannah,
                        Names.RaleighNorfolk,
                        Names.SavannahRaleigh,
                        Names.JacksonvilleSavannah,
                        Names.TampaJacksonville,
                        Names.TampaMiami
                    }
                },
                {Region.Names.Northeast, new string[]
                    {
                        Names.DetroitBuffalo,
                        Names.DetroitPittsburgh,
                        Names.PittsburghBuffalo,
                        Names.PittsburghWashington,
                        Names.BuffaloNewYork,
                        Names.NewYorkBoston,
                        Names.PhiladelphiaNewYork,
                        Names.WashingtonPhiladelphia
                    }
                },
                {Region.Names.Midwest, new string[]
                    {
                        Names.FargoDuluth,
                        Names.FargoMinneapolis,
                        Names.MinneapolisDuluth,
                        Names.MinneapolisChicago,
                        Names.DuluthChicago,
                        Names.StLouisChicago,
                        Names.StLouisCincinnati,
                        Names.ChicagoCincinnati,
                        Names.CincinnatiKnoxville
                    }
                }
            };
            #endregion

            #region border connection dictionary
            public static readonly Dictionary<string, string[]> ByBorder = new Dictionary<string, string[]>
            {
                {Region.Borders.NorthwestSouthwest, new string[]
                    {
                        Names.SanFranciscoPortland,
                        Names.SanFranciscoBoise,
                        Names.BoiseSaltLakeCity,
                        Names.SaltLakeCityDenver,
                        Names.SantaFeDenver
                    }
                },
                {Region.Borders.NorthwestSouth, new string[]
                    {
                        Names.DenverKansasCity,
                        Names.OmahaKansasCity
                    }
                },
                {Region.Borders.NorthwestMidwest, new string[]
                    {
                        Names.BillingsFargo,
                        Names.BillingsMinneapolis,
                        Names.CheyenneMinneapolis,
                        Names.OmahaChicago,
                        Names.OmahaMinneapolis
                    }
                },
                {Region.Borders.SouthwestSouth, new string[]
                    {
                        Names.SantaFeKansasCity,
                        Names.SantaFeOklahomaCity,
                        Names.SantaFeDallas,
                        Names.SantaFeHouston
                    }
                },
                {Region.Borders.MidwestSouth, new string[]
                    {
                        Names.KansasCityChicago,
                        Names.KansasCityStLouis,
                        Names.StLouisMemphis
                    }
                },
                {Region.Borders.SouthSoutheast, new string[]
                    {
                        Names.BirminghamAtlanta,
                        Names.BirminghamJacksonville,
                        Names.NewOrleansJacksonville
                    }
                },
                {Region.Borders.MidwestSoutheast, new string[]
                    {
                        Names.StLouisAtlanta,
                        Names.KnoxvilleAtlanta,
                        Names.CincinnatiRaleigh
                    }
                },
                {Region.Borders.MidwestNortheast, new string[]
                    {
                        Names.DuluthDetroit,
                        Names.ChicagoDetroit,
                        Names.CincinnatiDetroit,
                        Names.CincinnatiPittsburgh
                    }
                },
                {Region.Borders.NortheastSoutheast, new string[]
                    {
                        Names.PittsburghRaleigh,
                        Names.WashingtonNorfolk
                    }
                },
            };
            #endregion

            #region Connection Costs
            public static readonly Dictionary<string, int> Costs = new Dictionary<string, int>
            {
                {Names.PortlandSeattle, 3 },
                {Names.PortlandBoise, 13 },

                {Names.SanFranciscoPortland, 24 },
                {Names.SanFranciscoBoise, 23 },
                {Names.SanFranciscoSaltLakeCity, 27 },
                {Names.SanFranciscoLasVegas, 14 },
                {Names.SanFranciscoLosAngeles, 9 },

                {Names.LosAngelesLasVegas, 9 },
                {Names.LosAngelesSanDiego, 3 },

                {Names.SanDiegoLasVegas, 9 },
                {Names.SanDiegoPhoenix, 14 },

                {Names.SeattleBoise, 12 },
                {Names.SeattleBillings, 9 },

                {Names.BoiseBillings, 12 },
                {Names.BoiseCheyenne, 24 },
                {Names.BoiseSaltLakeCity, 8 },

                {Names.LasVegasSaltLakeCity, 18 },
                {Names.LasVegasSantaFe, 27 },
                {Names.LasVegasPhoenix, 15 },

                {Names.PhoenixSantaFe, 18 },

                {Names.SaltLakeCityDenver, 21 },
                {Names.SaltLakeCitySantaFe, 28 },

                {Names.BillingsFargo, 17 },
                {Names.BillingsMinneapolis, 18 },
                {Names.BillingsCheyenne, 9 },

                {Names.CheyenneMinneapolis, 18 },
                {Names.CheyenneOmaha, 14 },

                {Names.DenverCheyenne, 0 },
                {Names.DenverKansasCity, 16 },

                {Names.SantaFeDenver            , 13 },
                {Names.SantaFeKansasCity        , 16 },
                {Names.SantaFeOklahomaCity      , 15 },
                {Names.SantaFeDallas            , 16 },
                {Names.SantaFeHouston           , 21 },

                {Names.FargoDuluth              , 6 },
                {Names.FargoMinneapolis         , 6 },

                {Names.DuluthDetroit            , 15 },
                {Names.DuluthChicago            , 12 },

                {Names.MinneapolisDuluth        , 5 },
                {Names.MinneapolisChicago       , 8 },

                {Names.OmahaMinneapolis         , 8 },
                {Names.OmahaChicago             , 13 },
                {Names.OmahaKansasCity          , 5 },

                {Names.KansasCityChicago        , 8 },
                {Names.KansasCityStLouis        , 6 },
                {Names.KansasCityMemphis        , 12 },

                {Names.OklahomaCityKansasCity   , 8 },
                {Names.OklahomaCityMemphis      , 14 },
                {Names.OklahomaCityDallas       , 3 },

                {Names.DallasMemphis            , 12 },
                {Names.DallasNewOrleans         , 12 },
                {Names.DallasHouston            , 5 },

                {Names.HoustonNewOrleans        , 8 },

                {Names.ChicagoDetroit           , 7 },
                {Names.ChicagoCincinnati        , 7 },

                {Names.StLouisChicago           , 10 },
                {Names.StLouisCincinnati        , 12 },
                {Names.StLouisAtlanta           , 12 },
                {Names.StLouisMemphis           , 7 },

                {Names.MemphisBirmingham        , 6 },
                {Names.MemphisNewOrleans        , 7 },

                {Names.NewOrleansBirmingham     , 11 },
                {Names.NewOrleansJacksonville   , 16 },

                {Names.BirminghamAtlanta        , 3 },
                {Names.BirminghamJacksonville   , 9 },

                {Names.DetroitBuffalo           , 7 },
                {Names.DetroitPittsburgh        , 6 },

                {Names.CincinnatiDetroit        , 4 },
                {Names.CincinnatiPittsburgh     , 7 },
                {Names.CincinnatiRaleigh        , 15 },
                {Names.CincinnatiKnoxville      , 6 },

                {Names.KnoxvilleAtlanta         , 5 },
                
                {Names.AtlantaRaleigh           , 7 },
                {Names.AtlantaSavannah          , 7 },

                {Names.PittsburghBuffalo        , 7 },
                {Names.PittsburghWashington     , 6 },
                {Names.PittsburghRaleigh        , 7 },

                {Names.BuffaloNewYork           , 8 },

                {Names.NewYorkBoston            , 3 },

                {Names.PhiladelphiaNewYork      , 0 },

                {Names.WashingtonPhiladelphia   , 3 },
                {Names.WashingtonNorfolk        , 5 },

                {Names.RaleighNorfolk           , 3 },

                {Names.SavannahRaleigh          , 7 },

                {Names.JacksonvilleSavannah     , 0 },

                {Names.TampaJacksonville        , 4 },
                {Names.TampaMiami               , 4 }
            };
            #endregion
        }

        public static class Editions
        {
            public static class GameEditions
            {
                public const string Original = "Original";
                public const string Deluxe = "Deluxe";

                public static string Default = Original;
            }

            public static class BoardMap
            {
                public const string USA = "USA";
                public const string Germany = "Germany";

                public static string Default = USA;
            }

            public static class PlantCards
            {
                public const string Original = "Original";
                public const string New = "New";

                public static string Default = Original;
            }
        }
    }
}
