using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimitiveDataTypes
{
    class StringToIntConverter
    {
        /* Write a program to convert a given string to int, without using the int.tryparse or convert. 
         * Also give an option to convert for a base other than 10.
         */
        public void Main()
        {
            var ref1 = new StringToIntConverter();
            int outputInt = 0;
            var testList = new [] {"1","234","abc","2#$","1sd34"};

            foreach( var item in testList)
            {
                if (ref1.CustomTryParse(item, ref outputInt))
                    Console.WriteLine(outputInt);
                else
                    Console.WriteLine("{0} is not an int", item);
            }
          
        }

        public bool CustomTryParse(string str, ref int resultInt, int numBase = 10)
        {
            if (string.IsNullOrEmpty(str.Trim()))
                return false;
            var intValue = 0;
            var length = str.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                var asciiValue = (int)str[i];
                if (asciiValue > 57 || asciiValue < 48)
                    return false;
                intValue = intValue + ((asciiValue - 48) * (int)Math.Pow(numBase, length - i - 1));
            }

            resultInt = intValue;
            return true;

        }
    }
}
