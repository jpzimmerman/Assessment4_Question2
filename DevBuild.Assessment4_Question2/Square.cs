using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question2 {
    class Square : Shape {
        private float _side;

        public float SideValue {
            get => _side;
            set => _side = value;
        }

        public Square() : base()  => _side = 0.0f;

        public Square(float sideLength) : base() =>_side = sideLength;

        public override void Draw() => Console.WriteLine("Hi, I am a square!");

        public override float GetArea() => _side * _side;
    }
}