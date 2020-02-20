using System;
using System.Collections.Generic;

namespace SelfDev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var user = new User("Tom", 3214, "CZ001");
            var paymentType = new ApplyPay(user);
            var gateway = new PaymentGateway();
            gateway.TakePayment(paymentType, 350);

            Console.WriteLine("--Done--");
            /*
            var shapes = new List<Shape>
            {
                new Circle(),
                new Triangle(),
                new Lemniscate(),
                new Square()
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("--Done--");

            var cars = new List<ICar>
            {
                new BMW(),
                new Audi(),
                new Mercedes()
            };

            foreach (ICar car in cars)
            {
                car.Drive();
            }

            Console.WriteLine("--Done--");
   
            Exercises.IWontCheatOnTheExam();

            Console.WriteLine("--Done--");

            Exercises.DrawPyramid();

            Console.WriteLine("--Done--");

            Exercises.Loopy();

            Console.WriteLine("--Done--");

            Exercises.ChessBoard();

            */

        }
    }


}
