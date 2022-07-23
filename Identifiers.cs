using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifiers_and_Keywords
{
    class Identifiers
    {
        /*Rules for defining Identifires
               1.Identifiers are case sensitive.
               2.Keywords are not allowed to used as Identifiers.
               3.Spaces are not allowed.
               4.should not start with number/digits.
               5.follows naming conventioins for Identifiers - Camel case e.g. firstNumber
               6.use Pascel case for everything else e.g. FirstNumber
         */
        static void Main(string[] args)
        {
            byte smallNumber = 1;
            int largeNumber = 123;
            float pointValue = 2.54f;
            double largePointValue = 2.323;
            decimal valueOfPi = 3.14m;
            char singleLetter = 'S';
            bool isItWorking = true;

            Console.WriteLine(smallNumber);
            Console.WriteLine(largeNumber);
            Console.WriteLine(pointValue);
            Console.WriteLine(largePointValue);
            Console.WriteLine(valueOfPi);
            Console.WriteLine(singleLetter);
            Console.WriteLine(isItWorking);
            Console.ReadLine();

        }
    }
}
