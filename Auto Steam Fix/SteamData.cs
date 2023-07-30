
using System.Collections.Generic;

namespace Auto_Steam_Fix
{
    class SteamData
    {
        public class Data
        {
            public string type { get; set; }
            public string name { get; set; }
            public int steam_appid { get; set; }
            public int required_age { get; set; }
            public bool is_free { get; set; }
            public List<int> dlc { get; set; }
            public string detailed_description { get; set; }
            public string about_the_game { get; set; }
            public string short_description { get; set; }
            public string supported_languages { get; set; }
            public string reviews { get; set; }
            public string header_image { get; set; }
            public string website { get; set; }
        }

        public class Base
        {
            public bool success { get; set; }
            public Data data { get; set; }
        }

        public class RootObject
        {
            public Base Root { get; set; }
        }
    }
}
        
  


