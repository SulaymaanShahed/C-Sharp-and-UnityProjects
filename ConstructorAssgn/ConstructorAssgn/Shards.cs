using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssgn
{
    class Shards
    {
        public Shards(string name) : this(name, 100)
        {
        }

        public Shards(string name, int amount)
        {
            Type = new List<Gem>();
            Name = name;

        }
        public List<Gem> _type = new List<Gem>();
        public List<Gem> Type { get { return _type; } set { _type = value; } }
        public string Name { get; }
        public int V { get; set; }
    }
}
