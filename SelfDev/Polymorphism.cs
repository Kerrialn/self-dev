﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{
    
    class Shape
    {
        virtual public void Draw(){}
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

    class Lemniscate : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Lemniscate has been drawn");
        }
    }
}





