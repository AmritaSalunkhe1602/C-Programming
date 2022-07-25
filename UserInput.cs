using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInput
{
    class UserInput
    {
        static void Main(string[] args)
        {
            /* Console.Write("Enter Your First Name :");
             string firstName = Console.ReadLine();
             Console.Write("Enter your Last Name :");
             string lastName = Console.ReadLine();
             // Console.WriteLine("Hello," + firstName + " " + lastName);
             Console.WriteLine("Hello {0} {1}",firstName, lastName);
             Console.ReadLine();*/

            Console.Write("Enter First Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition is : {0}", num1 + num2);
            Console.ReadLine();
        }
    }
}
