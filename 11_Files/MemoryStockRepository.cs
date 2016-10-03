using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_Files
{
    internal class MemoryStockRepository : IStockRepository
    {
        private List<IAsset> SaveList = new List<IAsset>();
        long Id;
        public long NextId()
        {
            Id++;
            return Id;
        }

        public void SaveStock(Stock SavedAsset)
        {
            SaveList.Add(SavedAsset);
        }
        public Stock LoadStock(long id)
        {
            foreach (var item in SaveList)
            {
                if (item.Id == id)
                    return (Stock)item;
            }
            return null;
        }

        public ICollection FindAllStocks()
        {
            return SaveList;
        }

        public void Clear()
        {
            SaveList.Clear();
        }
    }
}