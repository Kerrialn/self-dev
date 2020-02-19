using System;
using System.Collections.Generic;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentType = new ApplyPay();
            var gateway = new PaymentGateway();
            gateway.TakePayment(paymentType, 350);

            Console.WriteLine("--Done--");

            var shapes = new List<Shape>
            {
                new Circle(),
                new Triangle(),
                new Square()
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("--Done--");
        }
    }


}
