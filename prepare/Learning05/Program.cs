using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
//Console.WriteLine("Hello Learning05 World!")
       List<Shape> shapes = new List<Shape>();

       Square square = new Square("red",5);
       shapes.Add(square);
       Rectangle rectangle = new Rectangle("green",5,5);
       shapes.Add(rectangle);
       Circle circle = new Circle("blue",10);
       shapes.Add(circle);
       
       foreach ( Shape s in shapes)
       {
         string color = s.GetColor();
         double area = s.GetArea();
         Console.WriteLine($"The {color} shape has an area of {area}.");
       }

}}