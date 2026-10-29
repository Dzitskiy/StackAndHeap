using System.Numerics;
using System.Runtime.CompilerServices;

Point p = new Point { X = 1, Y = 2 };
string s = p.ToString(); // boxing, если ToString() не переопределён

InvertValue invertValue = new InvertValue { X = 2 };

((IInvert)invertValue).Invert();

Console.WriteLine($"{invertValue.X}");

interface IInvert
{ void Invert(); }

struct InvertValue : IInvert
{
    public int X;
    public void Invert()
    { this.X *= (-1); }
}

struct Point
{
    public int X, Y;
    public override string ToString()
    {
        return string.Empty;
    }
}
