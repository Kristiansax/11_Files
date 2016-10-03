using System;
using System.Globalization;

namespace _11_Files
{
    public class SavingsAccount // : IAsset
    {
        public SavingsAccount (string Identification, int Worth, double Interest)
        {
            ID = Identification;
            Value = Worth;
            InterestRate = Interest;
        }
        string id;
        double value;
        double interestrate;
        string FormattedStringValue, FormattedStringInterestRate;
        public string ID
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
        public double Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return value;
            }
        }
        public double InterestRate
        {
            set
            {
                interestrate = value;
            }
            get
            {
                return interestrate;
            }
        }
        public double GetValue()
        {
            return Value;
        }
        public override string ToString()
        {
            FormattedStringValue = Value.ToString("F1", CultureInfo.InvariantCulture);
            FormattedStringInterestRate = InterestRate.ToString("F1", CultureInfo.InvariantCulture);
            return "SavingsAccount[value="+ FormattedStringValue +",interestRate="+ FormattedStringInterestRate +"]";
        }
        public void ApplyInterest()
        {
            Value = Value * (1 + (InterestRate / 100));
        }

        /*public string GetSymbol()
        {
            throw new NotImplementedException();
        }*/
    }
}