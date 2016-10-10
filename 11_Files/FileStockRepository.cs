using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    internal class FileStockRepository : IFileRepository
    {
        long Id;
        private List<IAsset> StockFiles = new List<IAsset>();
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public void Clear()
        {
            foreach (var item in repositoryDir.GetFiles())
            {
                item.Delete();
            }
        }

        public ICollection FindAllStocks()
        {
            StockIO SIO = new StockIO();
            foreach (var item in repositoryDir.GetFiles())
            {
                StockFiles.Add(SIO.ReadStock(new FileInfo(repositoryDir + item.ToString())));
            }
            Clear();
            return StockFiles;
        }

        public Stock LoadStock(long id)
        {
            StockIO SIO = new StockIO();
            return SIO.ReadStock(new FileInfo(StockFileName(id)));
        }

        public long NextId()
        {
            Id++;
            return Id;
        }

        public void SaveStock(Stock Asset)
        {
            
            NextId();
            Stock stock = Asset;
            stock.Id = Convert.ToInt32(Id);
            FileInfo f = new FileInfo(repositoryDir + StockFileName(stock));
            StockIO SIO = new StockIO();
            SIO.WriteStock(f, stock);
        }

        public string StockFileName(Stock stock)
        {
            return "stock" + stock.Id + ".txt";
        }

        public string StockFileName(long number)
        {
            return "stock" + number + ".txt";
        }
    }
}