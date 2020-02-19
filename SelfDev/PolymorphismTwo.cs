using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{


    interface ICar
    {
        void Drive();
    }


    class BMW : ICar
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a BMW");
        }
    }

    class Audi : ICar
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a Audi");
        }
    }

    class Mercedes : ICar
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a Mercedes");
        }
    }

}
