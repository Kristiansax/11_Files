using System;
using System.IO;


namespace _11_Files
{
    public class StockIO
    {
        public void WriteStock(StringWriter result, Stock x)
        {
            result.Write(x.Symbol + Environment.NewLine);
            result.Write(x.PricePerShare + Environment.NewLine);
            result.Write(x.NumShares + Environment.NewLine);
            result.Close();
        }
        public void WriteStock(FileInfo f, Stock s)
        {
            StreamWriter writer = new StreamWriter(f.ToString());
            writer.WriteLine(s.Id);
            writer.WriteLine(s.Symbol);
            writer.WriteLine(s.PricePerShare);
            writer.WriteLine(s.NumShares);
            writer.Close();
        }
        public Stock ReadStock(StringReader sr)
        {

            return new Stock(sr.ReadLine(), double.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
        }

        public Stock ReadStock(FileInfo f)
        {
            StreamReader reader = new StreamReader(f.ToString());
            Stock s = new Stock();
            s.Id = int.Parse(reader.ReadLine());
            s.Symbol = reader.ReadLine();
            s.PricePerShare = double.Parse(reader.ReadLine());
            s.NumShares = int.Parse(reader.ReadLine());
            reader.Close();
            return s;

        }
    }
}