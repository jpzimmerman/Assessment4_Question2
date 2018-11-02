using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question2 {
    class Shape : IShape {
        public Shape() { }

        public virtual void Draw() => Console.WriteLine("Hi, I am a shape!");
        public virtual float GetArea() => 0;
    }
}
