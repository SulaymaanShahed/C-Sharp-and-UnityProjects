using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssgn
{
    public class Shards
    {
        public Shards(string name) : this(name, 100, "One") //Chained Two constructors together.
        {
        }

        public Shards(string name, int amount, string carat)
        {
            Carat = carat;
            Amount = amount;
            Name = name;

        }
        public string Carat { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}
