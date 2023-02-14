using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213
{
    /*Создайте абстрактный базовый класс Фигура с аб-
страктным методом для подсчета площади.Создайте
производные классы: прямоугольник, круг, прямоугольный
треугольник, трапеция со своими реализациями метода
для подсчета площади.Для проверки определите массив
ссылок на абстрактный класс, которым присваиваются
адреса различных объектов классов-потомков.*/
    abstract class Shape
    {
        public abstract void Print();
        public abstract void Input();
        public abstract double Area();
        public abstract string ToString();
    }
    class Rectangle : Shape
    {
        private int a;
        private int b;

        public Rectangle(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public override double Area()
        {
            return a * b;
        }
        public override string ToString()
        {
            return "a: " + a + "\nb:"+b;
        }
        public override void Print()
        {
            Console.WriteLine("a: " + a + "\nb: "+b);
        }
        public override void Input()
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Triangle : Shape
    {
        private double a;
        private double h;

        public Triangle(int _a, int _h)
        {
            a = _a;
            h = _h;
        }
        public override double Area()
        {
            return a * h * 1/2;
        }
        public override string ToString()
        {
            return "a: " + a + "\nh:" + h;
        }
        public override void Print()
        {
            Console.WriteLine("a: " + a + "\nh: " + h);
        }
        public override void Input()
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter h: ");
            h = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Circle :Shape
    {
        private double r;

        public Circle(int _r)
        {
            r = _r;
        }
        public override double Area()
        {
            return Math.Pow(r,2) * 3.14;
        }
        public override string ToString()
        {
            return "r: " + r;
        }
        public override void Print()
        {
            Console.WriteLine("r: " + r);
        }
        public override void Input()
        {
            Console.WriteLine("Enter r: ");
            r = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Trapeze : Shape
    {
        private double a;
        private double b;
        private double h;

        public Trapeze(int _a,int _b,int _h)
        {
            a = _a;
            b = _b;
            h = _h;
        }
        public override double Area()
        {
            return (a+b)*h*1/2;
        }
        public override string ToString()
        {
            return "a: " + a+"\nb: "+b+"\nh: "+h;
        }
        public override void Print()
        {
            Console.WriteLine("a: " + a + "\nb: " + b + "\nh: " + h);
        }
        public override void Input()
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a: ");
            h = Convert.ToInt32(Console.ReadLine());
        }
    }
}
