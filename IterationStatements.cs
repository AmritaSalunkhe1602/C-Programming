using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSatements1
{
    class IterationStatements
    {
        static void Main(string[] args)
        {
            /*For loop
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            /*while loop Entry Controlled Loop
            int i = 10;
            while (i>=1)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadLine();
            */

            /*do while loop Exit Controlled loop*/
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
               
            
            Console.ReadLine();
        }

    }
}
