using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{
    interface IPayment
    {
        void Pay(double amount);
    }

    interface IFrudCheck
    {
         bool FrudCheck();
    }

    interface IProcessPayment
    {
         void Process(double amount);
    }

    interface I3Dcheck
    {
        public bool ThreeDCheck();
    }

    class WorldPay : IPayment, I3Dcheck, IProcessPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"you have successfully paid ${amount} with WorldPay");
        }

        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }

        public void Process(double amount)
        {
            if (this.ThreeDCheck() == true)
            {
                this.Pay(amount);
            }
        }
    }

    class PayPal : IPayment, I3Dcheck, IProcessPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"you have successfully paid ${amount} with Paypal");
        }
        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }
        public void Process(double amount)
        {
            this.ThreeDCheck();
            this.Pay(amount);
        }
    }

    class ApplyPay : IPayment, I3Dcheck, IProcessPayment, IFrudCheck
    {
        public bool FrudCheck()
        {
            Console.WriteLine("are you a fraudster?");
            var answer = Console.ReadLine();

            if (answer == "no")
            {
                Console.WriteLine("shame, we are!");
                return false;
            }
            else
            {
                Console.WriteLine("Woooo Hoooo! Let's start scamming people! ");
                return true;
            }

        }
        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"you have successfully paid ${amount} with ApplePay");
        }
        public void Process(double amount)
        {
            if (this.ThreeDCheck() == true && this.FrudCheck() == true)
            {
                this.Pay(amount);
            }
        }

    }

    class PaymentGateway
    {
        public void TakePayment(IProcessPayment paymentType, double amount)
        {
            paymentType.Process(amount);
        }
    }

}
