using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(int top, int bottom) // if fraction is passed
    {
        _top = top;
        _bottom = bottom;
    }

    public Fraction(int WholeNumber) // if whole number is passed
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction() // the default fraction is 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public void setFraction(int Top = 1,int Bottom = 0)
    {
        _top = Top;
        _bottom = Bottom;
    }

    public int getTop()
    {
        return _top;
    }
    public int getBottom()
    {
        return _bottom;
    }

    public String GetFractionString()
    {
        string toSender = $"{_top}/{_bottom}";
        return toSender;
    }

    public double GetDecimal()
    {
        double Trouble = (double)_top / (double)_bottom;
        return Trouble;
    }
}