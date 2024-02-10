using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HTTP
{
    internal class Root_bas_city_info
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string Loc_name { get; set; }
        public string Engl_name { get; set; }
        public string Prim_post_code { get; set; }
        public TimeZone Zone { get; set; }
        public bool Is_al { get; set; }
        public List<string> Data_sets { get; set; }
    }
}