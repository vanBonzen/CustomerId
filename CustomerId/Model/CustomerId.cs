namespace CustomerId.Model
{
    public class CustomerId
    {
        public string Number { get; set; }

        public bool CheckCustomerId(string customerId)
        {
            var middleNumber = int.Parse(customerId.Substring(2, 8));
            var lastDigits = int.Parse(customerId.Substring(10, 2));
            
            var crossSum = 0;
            while (middleNumber > 0)
            {
                crossSum += middleNumber % 10;
                middleNumber /= 10;
            }

            return ((lastDigits + crossSum) % 97) == 1;
        }
    }
}