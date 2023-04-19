using System.Drawing;


public interface LineEquation
{
    double Slope { get; set; }
    double Intercept { get; set; }
}

public interface LinePointSlope
{
    double Slope { get; set; }
    Point Point { get; set; }
}

public interface LineTwoPoints
{
    Point Point2 { get; set; }
    Point Point3 { get; set; }
}


public class Line : LineEquation, LinePointSlope, LineTwoPoints
{
    public double Slope { get; set; }
    public double Intercept { get; set; }

    public Point Point { get; set; }

    public Point Point2 { get; set; }
    public Point Point3 { get; set; }

    public Line(double slope, double intercept)
    {
        Slope = slope;
        Intercept = intercept;
    }

   
    public Line(double slope, Point point)
    {
        Slope = slope;
        Intercept = point.Y - slope * point.X;
        Point = point;
    }


    public Line(Point point2, Point point3)
    {
        Slope = (point3.Y - point2.Y) / (point3.X - point2.X);
        Intercept = point2.Y - Slope * point2.X;
        Point2 = point2;
        Point3 = point3;
    }

    public bool IsParallelFirst(LineEquation otherLine)
    {
        return this.Slope == otherLine.Slope;
    }

    public bool IsParallelSecond(LinePointSlope otherLine)
    {
        return this.Slope == otherLine.Slope;
    }

    public bool IsParallelThird(LineTwoPoints otherLine)
    {
        double deltaX1 = this.Point2.X - this.Point3.X;
        double deltaY1 = this.Point2.Y - this.Point3.Y;
        double deltaX2 = otherLine.Point2.X - otherLine.Point3.X;
        double deltaY2 = otherLine.Point2.Y - otherLine.Point3.Y;

        return deltaX1 * deltaY2 == deltaX2 * deltaY1;
    }


    public bool IsPerpendicularFirst(LineEquation otherLine)
    {
        return this.Slope * otherLine.Slope == -1;
    }

    public bool IsPerpendicularSecond(LinePointSlope otherLine)
    {
        return this.Slope * otherLine.Slope == -1;
    }

    public bool IsPerpendicularThird(LineTwoPoints otherLine)
    {
        double deltaX1 = this.Point2.X - this.Point3.X;
        double deltaY1 = this.Point2.Y - this.Point3.Y;
        double deltaX2 = otherLine.Point2.X - otherLine.Point3.X;
        double deltaY2 = otherLine.Point2.Y - otherLine.Point3.Y;

        return deltaX1 * deltaX2 + deltaY1 * deltaY2 == 0;
        //        3          4          -6      2
    }
    public static void Main() {
        Line line1 = new Line(-1.0, 1.0);
        Line line1_1 = new Line(-1.0, 1.0);

        Point Point2 = new Point(1, 3);
        Line line2 = new Line(0.5, Point2);
        Point Point2_1=new Point(2, 6);
        Line line2_2 = new Line(1, Point2_1);

        Point Point3 = new Point(6, -4);
        Point point3 = new Point(3, 2);
        Line line3 = new Line(Point3, point3);
        Point Point3_2 = new Point(10, 7);
        Point point3_3 = new Point(6, 6);
        Line line3_3 = new Line(Point3_2, point3_3);

        Console.WriteLine("Parallelism check: " + line3.IsParallelThird(line3_3));
        Console.WriteLine("Perpendicularity check: " + line3.IsPerpendicularThird(line3_3));
    
    }
}