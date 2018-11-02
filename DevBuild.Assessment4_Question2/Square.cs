using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question2 {
    class Square : Shape {
        private float Side;

        public float SideValue {
            get { return Side; }
            set { Side = value; }
        }

        public Square() : base() {
            Side = 0.0f;
        }

        public Square(float sideLength) : base() {
            Side = sideLength;
        }

        public override void Draw() {
            Console.WriteLine("Hi, I am a square!");
        }

        public override float GetArea() => Side * Side;
    }
}