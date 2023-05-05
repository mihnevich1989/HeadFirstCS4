using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    internal class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind {  get; set; }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }

        public int CompareTo(Duck? duckToCompare)
        {
            if (this.Size > duckToCompare?.Size)
            {
                return 1;
            } 
            else if (this.Size < duckToCompare?.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        
    }
}
