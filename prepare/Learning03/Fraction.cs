public class Fraction
{
    private int _topNumber; 
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;

    }
    public Fraction(int constructor1)
    {
        _topNumber = constructor1;
        _bottomNumber = 1;

    }
    public Fraction(int num, int den)
    {
        _topNumber = num;
        _bottomNumber = den;

    }

    public string GetFractionString()
    {
        string x = $"{_topNumber}/{_bottomNumber}";
        return x;
    }
    public double getDecimalValue()
    {
        return (double)_topNumber/(double)_bottomNumber;
    }

}