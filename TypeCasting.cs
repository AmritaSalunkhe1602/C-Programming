using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class TypeCasting
    {
        /*Type Connversion
         
         A.Implicit Type Conversion
             i)Both data type should be compatible to each other(i.e it should be store same typed value):
                     byte b=10;                      int i=32;
                     float f=b;//f=10                bool b=i;//not compatible
             
             ii)we can only assign smaller data type to the larger data type
                     int i=10;            byte b=10;
                     byte b=i;            int i=b;  // We can't

        B.Explicit Type Conversion
            i)We can convert value of larger data type to smaller data type
            ii)This is called Type Casting
            iii)Data may or may not lose

        C.Non Compatible Types
            i)by Using Convert Class 
                   different convert class methods are:
                             a)ToByte()
                             b)ToInt16() = short
                             c)ToInt32() = int
                             d)ToInt64() = long
                        
            ii)by Usig Parse Method
                  different parse methods are:
                             a)Byte.Parse()
                             b)short.Parse()
                             c)int.Parse()
                             d)bool.Parse()
           */
        static void Main(string[] args)
        {
            /*Implicit type conversion
             byte b = 10;
             int i = b;
             long l =  i;
             Console.WriteLine(i);
             Console.WriteLine(l);
             Console.ReadLine();
             */

            /*Explicit Type Conversion
             double d = 424.342;
            int i = (int)d;
            Console.WriteLine(i);
            Console.ReadLine();
            */

            /*Non Compatible Type Conversion
             
             */
            string s = "3452478";
            int i = Convert.ToInt32(s);    //using Convert class
            int ii = int.Parse(s);         //using Parse method
            Console.WriteLine(i);
            Console.WriteLine(ii);
            Console.ReadLine();
        }
    }
}
