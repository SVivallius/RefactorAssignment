using System.Text;
namespace Calculator.Classes;


class DoubleStack
{
    private double[] _data;
    private int _Depth { get; set; }

    public DoubleStack()
    {
        _data = new double[1000];
        _Depth = 0;
    }

    private void Push(double value)
    {
        _data[_Depth++] = value;
    }

    private double Pop()
    {
        if (_Depth > 0) return _data[--_Depth];

        Console.WriteLine("stack empty, returning 0");
        return 0;
    }

    private double Peek()
    {
        if (_Depth > 0) return _data[_Depth - 1];

        Console.WriteLine("stack empty, returning 0");
        return 0;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('[');
        for (int i = _Depth - 1; ; i--)
        {
            stringBuilder.Append(_data[i]);
            if (i == 0)
                return stringBuilder.Append(']').ToString();
            stringBuilder.Append(", ");
        }
    }

    public void RenderStack()
    {
        if (_Depth == 0)
        {
            Console.WriteLine("Commands: q c + - * / number");
            Console.WriteLine("[]");
        }
        else
        {
            Console.WriteLine(this.ToString());
        }
    }

    public void StackNumeric(double number)
    {
        Push(number);
    }

    public void ClearStack()
    {
        _Depth = 0;
    }

    public void Add()
    {
        Push(Pop() + Pop());
    }

    public void Substract()
    {
        double store = Pop();
        Push(Pop() - store);
    }

    public void Multiply()
    {
        Push(Pop() * Pop());
    }

    public void Divide()
    {
        double store = Pop();
        Push(Pop() / store);
    }
}
