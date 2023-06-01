using System.Text;
namespace Calculator.Classes;


class DoubleStack
{
    private double[] _data;
    public int Depth { get; private set; }

    public DoubleStack()
    {
        _data = new double[1000];
        Depth = 0;
    }

    public void Push(double value)
    {
        _data[Depth++] = value;
    }

    public double Pop()
    {
        if (Depth > 0) return _data[--Depth];

        Console.WriteLine("stack empty, returning 0");
        return 0;
    }

    public double Peek()
    {
        if (Depth > 0) return _data[Depth - 1];

        Console.WriteLine("stack empty, returning 0");
        return 0;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('[');
        for (int i = Depth - 1; ; i--)
        {
            stringBuilder.Append(_data[i]);
            if (i == 0)
                return stringBuilder.Append(']').ToString();
            stringBuilder.Append(", ");
        }
    }

    public void Clear()
    {
        Depth = 0;
    }
}
