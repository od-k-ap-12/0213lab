using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213
{
    class Human
    {
        private protected string Name { get; set; }
        private protected int Age { get; set; }

        public Human() : this("Human", 0) { }
        public Human(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name + "\t" + "Age:" + Age);
        }
        public virtual void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Name: " + Name + "\t" + "Age:" + Age;
        }
    }
    class Builder : Human
    {
        private protected int Experience { get; set; }

        public Builder(string _Name, int _Age, int _Experience) : base(_Name, _Age)
        {
            Experience = _Experience;
        }
        public override string ToString()
        {
            return base.ToString() + "Experience: " + Experience + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Experience: " + Experience + "\n");
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter years of experience: ");
            Experience = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Sailor : Human
    {
        private protected string ShipModel { get; set; }
        private protected int Experience { get; set; }

        public Sailor(string _Name, int _Age, string _ShipModel, int _Experience) : base(_Name, _Age)
        {
            ShipModel = _ShipModel;
            Experience = _Experience;
        }
        public override string ToString()
        {
            return base.ToString() + "Ship model: " + ShipModel + "\nExperience: " + Experience;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Ship model: " + ShipModel + "\nExperience: " + Experience);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter ship model: ");
            ShipModel = Console.ReadLine();
            Console.WriteLine("Enter years of experience: ");
            Experience = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Pilot : Human
    {
        private protected string PlaneModel { get; set; }
        private protected int Experience { get; set; }

        public Pilot(string _Name, int _Age, string _PlaneModel, int _Experience) : base(_Name, _Age)
        {
            PlaneModel = _PlaneModel;
            Experience = _Experience;
        }
        public override string ToString()
        {
            return base.ToString() + "Plane model: " + PlaneModel + "\nExperience: " + Experience;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Plane model: " + PlaneModel + "\nExperience: " + Experience);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter plane model: ");
            PlaneModel = Console.ReadLine();
            Console.WriteLine("Enter years of experience: ");
            Experience = Convert.ToInt32(Console.ReadLine());
        }
    }
}
