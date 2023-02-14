using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213
{
        abstract class Passport
        {
        private protected string FirstName { get; set; }
        private protected string LastName { get; set; }
        private protected string DateOfBirth { get; set; }
        private protected int Code { get; set; }

            public Passport() : this("FirstName","LastName","00.00.00000", 0) { }
            public Passport(string _FirstName,string _LastName, string _DateOfBirth, int _Code)
            {
                FirstName = _FirstName;
                LastName = _LastName;
                DateOfBirth = _DateOfBirth;
                Code = _Code;
            }
            public virtual void Print()
            {
                Console.WriteLine("First Name: " + FirstName + "\nLast Name:" + LastName + "\nDate of birth:" + DateOfBirth + "\nCode:" + Code);
            }
            public virtual void Input()
            {
                Console.WriteLine("Enter first name: ");
                FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                LastName = Console.ReadLine();
                Console.WriteLine("Enter date of birth: ");
                DateOfBirth = Console.ReadLine();
                Console.WriteLine("Enter code: ");
                Code = Convert.ToInt32(Console.ReadLine());
            }
            public override string ToString()
            {
                return "First Name: " + FirstName + "\nLast Name:" + LastName + "\nDate of birth:" + DateOfBirth + "\nCode:" + Code;
            }
        }
        class ForeignPassport : Passport
        {
        private protected string Visas { get; set; }

            public ForeignPassport(string _Name, int _Age, string _Visas) : base("FirstName", "LastName", "00.00.00000", 0)
            {
                Visas = _Visas;
            }
            public override string ToString()
            {
                return base.ToString() + "Visas: " + Visas + "\n";
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine("Visas: " + Visas + "\n");
            }
            public override void Input()
            {
                base.Input();
                Console.WriteLine("Enter visas: ");
                Visas = Console.ReadLine();
            }
        }
    }

