using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAssertExampleApp
{
    public class CalculatorWithoutAssert
    {
        public void Calculate()
        {
            int numberToParse;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            var userNumber = Console.ReadLine();
           
            while (!int.TryParse(userNumber, out numberToParse))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz:");
                userNumber = Console.ReadLine();
            }

            foreach (var evenNumber in GetEvenNumbers())
            {
                if (evenNumber != 0)
                    Console.WriteLine(numberToParse / evenNumber);
            }
        }

        private ICollection<int> GetEvenNumbers()
        {
            return new List<int>() { 0, 2, 4, 6, 8 };
        }
    }
}
