using System;

namespace CustomerId.Model
{
    public class CustomerIdFactory
    {
        public CustomerId NewCustomerId()
        {
            var temp = new CustomerId();
            var rnd = new Random();
            
            const string start = "TM";
            var middle = "";

            // Numbers 3-10
            for (var i = 0; i < 8; i++)
            {
                middle += rnd.Next(1, 10).ToString();
            }
            var middleInt = int.Parse(middle);

            // Produce Checkdigits
            var crossSum = 0;
            while (middleInt > 0)
            {
                crossSum += middleInt % 10;
                middleInt /= 10;
            }
            var lastDigits = (98 - crossSum) % 97;
            var end = lastDigits.ToString();
            
            // Console.WriteLine((lastDigits + crossSum) % 97);
            temp.Number = start + middle + end;

            return temp;
        }
    }
}