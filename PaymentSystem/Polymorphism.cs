using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSystem
{

    class Shape
    {
        virtual public void Draw() { }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle has been drawn");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square has been drawn");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle has been drawn");
        }
    }
}


