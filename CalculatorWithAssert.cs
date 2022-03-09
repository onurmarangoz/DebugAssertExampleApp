using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAssertExampleApp
{
    public class CalculatorWithAssert
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
                //Örnek Assert kontrolu
                Debug.Assert(evenNumber != 0, "Sıfır bölen olamaz");
                Console.WriteLine(numberToParse / evenNumber);
            }
        }

        private ICollection<int> GetEvenNumbers()
        {
            return new List<int>() {  2, 4, 6, 8 };
        }

    }
}
