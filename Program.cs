class TSquare
{
    public double alength;
    public double blength;

    public TSquare()
    {

    }
    public TSquare(double firstlength)
    {
        alength = firstlength;
    }
    public TSquare(TSquare anotherTRectangle)
    {
        alength = anotherTRectangle.alength;
    }
    public virtual void dataInput()
    {
        Console.WriteLine("Введіть довжину сторони квадрата");
        alength = Convert.ToDouble(Console.ReadLine());
    }
    public virtual void dataOutput()
    {
        Console.WriteLine("Довжина сторони квадрата:" + alength);
        Console.WriteLine("Площа квадрата:" + Squarecount());
        Console.WriteLine("Периметр квадрата:" + Perimetercount());
    }
    public virtual double Squarecount()
    {
        double square = Math.Pow(alength, 2);
        return square;
    }
    public virtual double Perimetercount()
    {
        double perimeter = (alength * 4);
        return perimeter;
    }
    public virtual void dataInputComparison()
    {
        Console.WriteLine("Введіть довжину сторони квадрата для порівняння");
        blength = Convert.ToDouble(Console.ReadLine());
    }
    public virtual void Comparison()
    {
        if (alength == blength)
        {
            Console.WriteLine("Квадрати рівні");
        }
        else
        {
            Console.WriteLine("Квадрати нерівні");
        }
    }

    public static double operator +(TSquare anotherTSquare)
    {
        return (anotherTSquare.alength + anotherTSquare.alength);
    }
    public static double operator -(TSquare anotherTSquare)
    {
        return (anotherTSquare.alength - anotherTSquare.alength);
    }

    public static TSquare operator *(TSquare anotherTSquare, double multiplier)
    {
        anotherTSquare.alength *= multiplier;
        return anotherTSquare;
    }

    public static void Main(String[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        TSquare TSquareExample = new TSquare();
        TSquareExample.dataInput();
        TSquareExample.dataOutput();
        TSquareExample.dataInputComparison();
        TSquareExample.Comparison();
        Console.WriteLine("Перевантажений +:" + +TSquareExample);
        Console.WriteLine("Перевантажений -:" + -TSquareExample);
        TSquare TSquareExample2 = new TSquare(TSquareExample);
        Console.WriteLine("Введіть множник");
        double ExMultiplier = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Перевантажений *:");
        TSquareExample2 *= ExMultiplier;
        TSquareExample2.dataOutput();

        TCube tc = new TCube();
        tc.dataInput();
        tc.dataOutput();
        tc.dataInputComparison();
        tc.Comparison();
    }
}
class TCube : TSquare
{
    public double clength;
    public double dlength;

    public override void dataInput()
    {
        Console.WriteLine("Введіть довжину ребра куба");
        clength = Convert.ToDouble(Console.ReadLine());
    }
    public double Capacity()
    {
        double capacity = Math.Pow(clength, 3);
        return capacity;
    }
    public override double Squarecount()
    {
        double square = 6 * Math.Pow(clength, 2);
        return square;
    }
    public override double Perimetercount()
    {
        double perimeter = 12 * clength;
        return perimeter;
    }
    public override void dataOutput()
    {
        Console.WriteLine("Довжина сторони куба:" + clength);
        Console.WriteLine("Площа куба:" + Squarecount());
        Console.WriteLine("Периметр куба:" + Perimetercount());
    }
    public override void dataInputComparison()
    {
        Console.WriteLine("Введіть довжину ребра куба для порівняння");
        dlength = Convert.ToDouble(Console.ReadLine());
    }
    public override void Comparison()
    {
        if (clength == dlength)
        {
            Console.WriteLine("Куби рівні");
        }
        else
        {
            Console.WriteLine("Куби нерівні");
        }
    }

}
