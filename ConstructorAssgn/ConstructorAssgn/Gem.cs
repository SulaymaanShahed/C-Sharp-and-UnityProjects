using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssgn
{
    public class Gem
    {
        public Carat Carat { get; set; }
        public Shape Shape { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Carat, Shape);
        }
    }
    public enum Carat
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
    public enum Shape
    {
        Round,
        Princess,
        Marquise,
        Emerald,
        Pear,
        Oval,
        Heart
    }
}
