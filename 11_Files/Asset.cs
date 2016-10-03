namespace _11_Files
{
    public interface IAsset
    {
        int Id {get;}

        double GetValue();
        string GetSymbol();
        double GetPricePerShare();
    }
}