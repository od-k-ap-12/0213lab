using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes = new Shape[3];
            Shapes[0] = new Rectangle(3, 3);
            Shapes[1] = new Triangle(4, 7);
            Shapes[2] = new Trapeze(10,3,5);
        }
    }
}
