using System;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentType = new WorldPay();
            var gateway = new PaymentGateway();
            gateway.TakePayment(paymentType, 350);

        }
    }

    interface IPayment
    {
        public void Pay(double amount);
    }

    interface IFrudCheck
    {
        public void FrudCheck();
    }

    interface IProcessPayment
    {
        public void Process(double amount);
    }

    interface I3Dcheck
    {
        public bool ThreeDCheck();
    }

    class WorldPay : IPayment, I3Dcheck, IProcessPayment
    {
        public void Pay(double amount) {
            Console.WriteLine($"you have successfully paid ${amount} with WorldPay");
        }

        public bool ThreeDCheck() {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }

        public void Process(double amount) {
            if(this.ThreeDCheck() == true)
            {
                this.Pay(amount);
            }
        }
    }

    class PayPal : IPayment, I3Dcheck, IProcessPayment
    {
        public void Pay(double amount) {
            Console.WriteLine($"you have successfully paid ${amount} with Paypal");
        }
        public bool ThreeDCheck() {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }
        public void Process(double amount) {
            this.ThreeDCheck();
            this.Pay(amount);
        }
    }

    class ApplyPay : IPayment, I3Dcheck, IProcessPayment, IFrudCheck
    {
        public void FrudCheck() { }
        public bool ThreeDCheck() {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return pin == "1234" ? true : false;
        }
        public void Pay(double amount) {
            Console.WriteLine($"you have successfully paid ${amount} with ApplePay");
        }
        public void Process(double amount)
        {
            this.FrudCheck();
            this.ThreeDCheck();
            this.Pay(amount);
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
