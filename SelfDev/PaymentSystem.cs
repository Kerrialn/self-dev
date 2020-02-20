using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDev
{
    interface IPayment
    {
        public User User { get; set; }
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
        public User User { get; set; }

        public WorldPay(User user)
        {
            this.User = user;
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"you have successfully paid ${amount} with WorldPay");
        }

        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            Console.WriteLine(this.User.Pin);
            return Int16.Parse(pin) == this.User.Pin ? true : false;
        }

        public void Process(double amount)
        {
            if (ThreeDCheck())
            {
                Pay(amount);
            }
            else
            {
                Console.WriteLine("incorrect pin");
            }
        }
    }

    class PayPal : IPayment, I3Dcheck, IProcessPayment
    {
        public User User { get; set; }
        public PayPal(User user)
        {
            this.User = user;
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"{this.User.AccountNumber} - ${amount} paid with Paypal");
        }
        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return Int16.Parse(pin) == this.User.Pin ? true : false;
        }
        public void Process(double amount)
        {
            this.ThreeDCheck();
            this.Pay(amount);
        }
    }

    class ApplyPay : IPayment, I3Dcheck, IProcessPayment, IFrudCheck
    {
        public User User { get; set; }
        public ApplyPay(User user)
        {
            this.User = user;
        }
        public bool FrudCheck()
        {
            Console.WriteLine("Please enter your account number:");
            var inputAccountNumber = Console.ReadLine();
            return inputAccountNumber == this.User.AccountNumber ? true : false;
        }
        public bool ThreeDCheck()
        {
            Console.WriteLine("3D Security check: please enter your security pin");
            var pin = Console.ReadLine();
            return Int16.Parse(pin) == this.User.Pin ? true : false;
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"you have successfully paid ${amount} with ApplePay");
        }
        public void Process(double amount)
        {
            if (ThreeDCheck() && this.FrudCheck())
            {
                Pay(amount);
            }
            else
            {
                Console.WriteLine("incorrect pin");
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

    class User
    {
        public string Name { get; set; }
        public int Pin { get; set; }
        public string AccountNumber { get; set; }

        public User(string name, int pin, string accountNumber)
        {
            this.Name = name;
            this.Pin = pin;
            this.AccountNumber = accountNumber;
        }
    }

}
