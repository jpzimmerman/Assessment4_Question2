using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question2 {
    class Program {
        static void Main(string[] args) {
            Square testSquare = new Square(10);
            testSquare.Draw();
            Console.WriteLine($"My area is {testSquare.GetArea()} sq. units");
            while (true) { }
        }
    }
}
