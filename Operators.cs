using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            /*Arithmetic Operators
            int a = 10, b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine();
            */

            /*Unary Operator they are also Arithmetic operator
             
            Operation      Symbols        Example       Prefix     Postfix

            Increment         ++            a++           ++a        a++
                                          (a=a+1)

            Decrement        --             a--           --a         a--
                                          (a=a-1)


            Prefix Increment
                         a=1;
                         b=++a;      so,a=2 & b=2

            Postfix Dcrement
                        a=1; 
                        b=a++;       so,a=2 & b=1

            same for Decrement
             */

            /*Assignment Operator
             
             Assignment               =         a=10
             Addition Assign.         +=        a+=b          a=a+b
             Subtract Assign.         -=        a-=b          a=a-b
             Multiple Assign.         *=        a*=b          a=a*b
             Divide Assign.           /=        a/=b          a=a/b
             Modulus Assign.          %=        a%=b          a=a%b
             */

            /*Relational/Comparison Operator
             
            Equal to                  ==        a==b        2==2     true
            Not Equal                 !=        a!=b        2!=3     true
            Greater than              >         a>b         3>2      true
            Greater than equal to     >=        a>=b        3>=2     true
            Less than                 <         a<b         2<5      true
            Less than equal to        <=        a<=b        3<=3     true
              */

            /*Logical Operators
             
            Logical AND       &&
            Logical OR        ||
            Logical NOT       !
             */

            int a = 2, b = 4, c = 2;
            Console.WriteLine(a == b && a == c);       //False
            Console.WriteLine(a == b || a == c);       //True
            Console.WriteLine(!(a == b || a == c));    //False
            Console.ReadLine();
        }
    }
}
