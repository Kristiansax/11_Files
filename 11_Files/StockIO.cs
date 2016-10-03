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
        }
    }
}