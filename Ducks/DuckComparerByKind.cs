using System.Collections.Generic;

namespace Ducks
{
    internal class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck? x, Duck? y)
        {
            if (x?.Kind < y?.Kind)
            {
                return -1;
            }
            if (x?.Kind > y?.Kind)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
