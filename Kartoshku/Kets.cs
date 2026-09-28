using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoshku
{
    internal class Kets
    {
        public string Name { get; set; }
        public string Cover { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Taken { get; set; }
        public string Status
        {
            get { return $"В наличии: {Count}, На руках: {Taken}"; }
        }

    }
}
