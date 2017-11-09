using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pali(22));
            Console.Read();
        }

        static int Pali(int n)
        {
            int r, res = 0, sum = 0, temp;//decimal

            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                res += 1;//decimal

            n = temp;
            string binaryNumber = Convert.ToString(n, 2); //binary
            if (checkPalindromeString(binaryNumber)) {
            res += 2;
            }//binary

            string hexaNumber = n.ToString("X");

            if (checkPalindromeString(hexaNumber))
            {
                res += 8;
            }


            n = convertDecimalToOctal(n);

            r = 0;//octa
            
            sum = 0;
            temp=0;

            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                res += 4;//octal

            return res;
        }

        static int convertDecimalToOctal(int decimalNumber)
        {
            int octalNumber = 0, i = 1;

            while (decimalNumber != 0)
            {
                octalNumber += (decimalNumber % 8) * i;
                decimalNumber /= 8;
                i *= 10;
            }

            return octalNumber;
        }
      

        static bool checkPalindromeString(string numberString)
        {
            string leftMostHalf = numberString.Substring(0, numberString.Length / 2);
            char[] arr = numberString.ToCharArray();
            Array.Reverse(arr);
            string tempArr = new string(arr);
            string RightMostHalf = tempArr.Substring(0, tempArr.Length / 2);
            return leftMostHalf.Equals(RightMostHalf);
        }
    }
}
