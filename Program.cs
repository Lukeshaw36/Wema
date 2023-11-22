using System.Collections.Generic;
using System.Transactions;
using Wema.Bit;
using Wema.Bit.Model;

namespace Wema.Bit;

//    public class User
//    {
//        public static void Main(string[] args)

//        {
//            Console.WriteLine("Hello world!");

//            Payment.Greet();
//            Payment p = new Payment();
//            p.GreetMe();

//            string greet = p.GreetMe();

//            Console.WriteLine(greet);

//        }
//    }

//    public class Payment
//    {
//        public static void Greet()
//        {
//            Console.WriteLine("Good Afternoon");
//        }

//        public string GreetMe()
//        {
//            Console.WriteLine("Good Afternoon");

//            return "Good Afternoon ma";
//        }
//    }
//}



public class User
{
    public static void Main(string[] args)

    {

        List<Users> users = new List<Users>()
        {
             new Users() {Id = 1, FirstName="Luke", LastName="Duvbiama",
            Email="Lukemorlakemi@gmail.com"},
            new Users() {Id = 2, FirstName="James", LastName="Adebayo",
            Email="jamesadebayo@gmail.com"},
            new Users() {Id= 3, FirstName="Sam", LastName="Jdoka",
            Email="Samjohn@gmail.com"},
            new Users() {Id = 4, FirstName="Cynthia", LastName="Morgan",
            Email="josephudokae@gmail.com"},
            new Users() {Id = 5, FirstName="Micheal", LastName="Jackson",
            Email="Michealjackson@gmail.com"},
        };

        List<Payments> payments = new List<Payments>()
        {

            new Payments() {UserId = 1, PaymentId = 1, PayAmount = 2500},
            new Payments() {UserId = 2, PaymentId = 2, PayAmount = 1400},
            new Payments() {UserId = 3, PaymentId = 3, PayAmount = 2600},
            new Payments() {UserId = 4, PaymentId = 4, PayAmount = 6700},
            new Payments() {UserId = 5, PaymentId = 5, PayAmount = 8900},
        };


        foreach (var user in users)
        {
            Console.WriteLine($"User: {user.FirstName} {user.LastName}, Email: {user.Email}");


            var userPayments = payments.Where(p => p.UserId == user.Id);


            foreach (var userPayment in userPayments)
            {
                Console.WriteLine($"  PaymentId: {userPayment.PaymentId}, Amount: {userPayment.PayAmount}");
            }

            Console.WriteLine();


        }
    }
}








