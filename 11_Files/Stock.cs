using System.Globalization;
namespace _11_Files
{
    public class Stock : IAsset
    {
        public Stock()
        {

        }
        public Stock(string Type, double PPS, int AmountOfShares)
        {
            Symbol = Type;
            PricePerShare = PPS;
            NumShares = AmountOfShares;
        }
        private string symbol;
        private double pricepershare;
        private int numshares, id;
        
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol;
            }
        }
        public double PricePerShare
        {
            set
            {
                pricepershare = value;
            }
            get
            {
                return pricepershare;
            }
        }
        public int NumShares
        {
            set
            {
                numshares = value;
            }
            get
            {
                return numshares;
            }
        }

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public double GetValue()
        {
            return NumShares * PricePerShare; 
        }
        public static double TotalValue(IAsset[] stocks)
        {
            double sum = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                sum = sum + stocks[i].GetValue();
            }
            return sum;
        }
        public override string ToString()
        {
            return "Stock[symbol=" + Symbol +",pricePerShare="+ PricePerShare +",numShares="+ NumShares +"]";
        }
        public bool Equals(Stock SameCheck)
        {
            if (Symbol.Equals(SameCheck.Symbol) && PricePerShare.Equals(SameCheck.PricePerShare) && NumShares.Equals(SameCheck.NumShares))
                return true;
            else
                return false;
        }
        public string GetSymbol()
        {
            return Symbol;
        }
        public double GetPricePerShare()
        {
            return PricePerShare;
        }
        public int GetNumShares()
        {
            return NumShares;
        }

    }
}