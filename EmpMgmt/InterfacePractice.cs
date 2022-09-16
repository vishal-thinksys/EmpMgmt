using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public interface IAreaCalculator
    {
        double GetArea();
    }
    public class Circle : IAreaCalculator
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
    public class Rectangle : IAreaCalculator
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Height * Width;
        }
    }

    public class Triangle : IAreaCalculator
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return Height * Width * 0.5;
        }
    }

    public class InterfacePractice
    {
      
       public void CircleArea(double rad)
        {
            IAreaCalculator myCalc = new Circle()
            {
                Radius = rad
            };
            PrintOutPut("Circle", Convert.ToDouble(myCalc.GetArea()));
        }
        public void RectangleArea(double hei,double wid)
        {
            IAreaCalculator myCalc = new Rectangle()
            {
                Height = hei,
                Width = wid
            };
            PrintOutPut("Rectangle", Convert.ToDouble(myCalc.GetArea()));           
        }
        public void TriangleArea(double hei, double wid)
        {
            IAreaCalculator myCalc = new Triangle()
            {
                Height = hei,
                Width = wid
            };
            PrintOutPut("Triangle", Convert.ToDouble(myCalc.GetArea()));
        }
        void PrintOutPut(string text,double Area)
        {
            Console.WriteLine("Area of {0} is {1}",text,Area.ToString());
        }
    }
}
