using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213
{
    abstract class Animal
    {
        private protected string Name { get; set; }
        private protected int Age { get; set; }
        private protected string Location { get; set; }

        public Animal() : this("Animal", 0,"Location") { }
        public Animal(string _Name, int _Age, string _Location)
        {
            Name = _Name;
            Age = _Age;
            Location = _Location;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name + "\nAge:" + Age + "\nLocation:" + Location );
        }
        public virtual void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter location: ");
            Name = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nAge:" + Age + "\nLocation:" + Location;
        }
    }
    class Tiger : Animal
    {
        private static int Counter=0;

        public Tiger(string _Name, int _Age, string _Location) : base(_Name, _Age,_Location)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Input()
        {
            base.Input();
        }
    }
    class Crocodile : Animal
    {
        private static int Counter=0;

        public Crocodile(string _Name, int _Age, string _Location) : base(_Name, _Age,_Location)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Input()
        {
            base.Input();
        }
    }

    class Kangaroo : Animal
    {
        private static int Counter=0;

        public Kangaroo(string _Name, int _Age, string _Location) : base(_Name, _Age,_Location)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Input()
        {
            base.Input();
        }
    }
}
