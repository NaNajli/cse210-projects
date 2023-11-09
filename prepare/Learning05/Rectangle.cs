using System;
public class Rectangle:Shape
{
   private double _length;
   private double _width;

   public Rectangle(string color , double length, double width):base(color)
   {
    double _width = width;
    double _length = length;
   }

   public  void SetLength(double length)
   {
    double _length = length;
   }
   public double GetLength()
   {
    return _length;
   }
   public void SetWidth(double width)
   {
    double _width = width;
   }
   public double GetWidth()
   {
    return _width;
   }
    public override double GetArea()
    {
        return _length * _width;
    }
}