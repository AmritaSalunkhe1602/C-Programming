using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DataTypeVariables
    {
       /*Data Type   Keywords   Bytes         Range
        
                     byte         1          0 to 255
       Integer       short        2          -32,768 to 32,767
                     int          4          -2.1B to 2.1B
                     long         8          -9,223,372,036,854,775,808 to 9,223,372,036,775,807

                     float        4          -3.4*10`38 to 3.4*10`38
       Real numbers  double       8               -
                     decimal      16         -7.9*1`28 to 7.9*10`28

        Character    char         2          Unicode Characters

        Boolean      bool         1          true/false
        
       */
        static void Main(string[] args)
        {
            /* syntax for declaring variable is  Data_type Variable_Name = Literal;*/
            byte b = 12;
            int i = 981;
            float f = 3.9f;
            double d = 29.87;
            decimal m = 98.65m;
            char c = 'A';
            bool l = true;

            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(d); 
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
}
