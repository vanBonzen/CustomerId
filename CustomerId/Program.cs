using System;
using CustomerId.Model;

namespace CustomerId
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var factory = new CustomerIdFactory();
            var customerId = factory.NewCustomerId();
            
            Console.WriteLine(customerId.Number);

            Console.WriteLine(customerId.CheckCustomerId("TM8743311765"));
        }
    }
}