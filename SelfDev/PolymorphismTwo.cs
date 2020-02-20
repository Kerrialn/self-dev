using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{
    interface ICar
    {
        public string Name { get; set; }
        void Drive();
    }

    class BMW : ICar
    {
        public string Name { get; set; } 

        public void Drive()
        {
            Console.WriteLine("You are driving a BMW");
        }
    }

    class Audi : ICar
    {
        public string Name { get; set; }
        public void Drive()
        {
            Console.WriteLine("You are driving a Audi");
        }
    }

    class Mercedes : ICar
    {
        public string Name { get; set; }
        public void Drive()
        {
            Console.WriteLine("You are driving a Mercedes");
        }
    }

}
