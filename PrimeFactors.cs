using System.Text;
using static System.Console;

namespace Ch04Ex02PrimeFactorsLib
{


    public static class PrimeFactors
    {
        /// <summary>
        /// Returns a list of prime numbers from 2 to the given number
        /// </summary>
        /// <param name="number"></param>
        public static List<int> FindPrimeNumbers(int number)
        {
            List<int> primeNumbersList = new List<int>();

            for (int i = 2; i <= number; i++)
            {
                bool isPrimeNumber = true;

                for (int j = 2; j < i; j++)
                {
                    //Check to see if the number is divisible by another number and if that is the case, then it is not a prime number. If it's not divisible, then it is a prime number
                    if (i % j == 0 )
                    {
                        isPrimeNumber = false;
                        break; //if the number is not a prime number, stop dividing by other numbers in the loop. break out.
                    }
                }

                if (isPrimeNumber)
                {
                    primeNumbersList.Add(i);
                }
            }
            //Display the prime numbers
            //foreach (var primeNumber in primeNumbersList)
            //{
            //    Write($"{primeNumber} * ");
            //}

            return primeNumbersList;
        }


        /// <summary>
        /// This method returns the prime factors of a given number between 1 and 1000
        /// </summary>
        /// <param name="number">An integer between 1 and 1000 </param>
        /// <returns>A string listing the prime factors of the number</returns>
        public static string PrimeFactorsGenerate(int number)
        {
            if (number <= 0 || number > 1000)
            {
                return $"{nameof(number)} must be between 1 and 1000.";
            }
            else
            {
                List<int> primeNumbers = new List<int>();
                primeNumbers = FindPrimeNumbers(number);

                string factors = string.Empty;

                foreach (int divisor in primeNumbers)
                {
                    int remainder;
                    //Keep dividing the number by the divisors from the primeNumbers' list as long as division remainder is 0 (which means the number is divisible). If number equals 1, then the number is naturally a prime number. Else, you display the divisor and continue dividing.
                    do
                    {
                        remainder = number % divisor;
                        if (remainder == 0)
                        {
                            number = number / divisor;
                            if (number == 1)
                            {
                                factors += $"{divisor}";
                            }
                            else
                            {
                                factors += $"{divisor} * ";
                            }
                        }
                    } while (remainder == 0);
                }
                return $"{factors}";
            }
        }
    }
}