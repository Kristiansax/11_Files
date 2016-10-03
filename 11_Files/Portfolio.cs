using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _11_Files

{
    public class Portfolio
    {
        List<IAsset> assetlist = new List<IAsset>();
        public Portfolio()
        {
            assetlist = new List<IAsset>();
        }
        public Portfolio(List<IAsset> List)
            {
                assetlist = List;
            }
        public double GetTotalValue()
        {
            double Total = 0;
            foreach (IAsset item in assetlist)
                Total = Total + item.GetValue();
            return Total;
        }
        public void AddAsset(IAsset asset)
        {
            assetlist.Add(asset);
        }

        internal IList<IAsset> GetAssets()
        {          
            return assetlist.AsReadOnly();
        }

        internal IAsset GetAssetByName(string SearchAsset)
        {
            for (int i = 0; i < assetlist.Count; i++)
            {
                if (assetlist[i].GetSymbol().Equals(SearchAsset))
                    return assetlist[i];
            }
            return null;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            IComparer<IAsset> compare = new StockNameComparator();
            assetlist.Sort(compare);
            return assetlist;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            IComparer<IAsset> compare = new StockValueComparator();
            assetlist.Sort(compare);
            return assetlist;
        }
    }
}