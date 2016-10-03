
using System.Collections.Generic;

namespace _11_Files
{
    public class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return x.GetSymbol().CompareTo(y.GetSymbol());           
        }

    }
}