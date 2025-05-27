
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _topNum;
    public int _bottomNumbers;

    public Fraction()
    {
        _topNum = 1;
        _bottomNumbers = 1;
    }

    public Fraction(int _topNumber)
    {
        _topNum = _topNumber;
        _bottomNumbers = 1;
    }

    public Fraction(int _topNumber, int _bottomNumber)
    {
        _topNum = _topNumber;
        _bottomNumbers = _bottomNumber;

    }

    public string GetFractionString()
    {
        return $"{_topNum}/{_bottomNumbers}";
    }

    public double GetDecimalValue()
    {
        return (double) _topNum / (double) _bottomNumbers;
    }
    

    

}