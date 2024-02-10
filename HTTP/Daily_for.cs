using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    internal class Daily_for
    {
        public float Temperature { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public int Ep_date { get; set; }
        public List<string> sources { get; set; }
        public string Mob_link { get; set; }
        public string Link { get; set; }
    }
}