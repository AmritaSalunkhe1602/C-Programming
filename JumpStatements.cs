using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements2
{
    class JumpStatements
    {
        static void Main(string[] args)
        {
            /*Break Statement
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

                if (i == 5)
                {
                    break;
                }
            }
            Console.ReadLine();
            */

            /*Continue Statements*/
             for(int i = 0; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
