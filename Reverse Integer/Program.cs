//https://leetcode.com/problems/reverse-integer/
//Accepted: 0.85% :<
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Reverse(901000));

            Console.Read();
        }

        static int Reverse(int x)
        {
            if (x > 0)
            {
                if (x % 10 == 0)
                {
                    return Convert.ToInt32(new string(x.ToString().Reverse().ToArray()).TrimStart('0'));
                }

                if (Convert.ToInt64(new string(x.ToString().Reverse().ToArray())) > Int32.MaxValue)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(new string(x.ToString().Reverse().ToArray()));
                }
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                if (x % 10 == 0)
                {
                    return (0 - Convert.ToInt32(new string(x.ToString().Replace("-", "").Reverse().ToArray()).TrimStart('0')));
                }

                if (Convert.ToInt64(new string(x.ToString().Replace("-", "").Reverse().ToArray())) > Int32.MaxValue)
                {
                    return 0;
                }
                else
                {
                    return (0 - Convert.ToInt32(new string(x.ToString().Replace("-", "").Reverse().ToArray())));
                }                
            }

            // end of function
        }

        /*
         * 
        public int reverse(int x) {
            long rev= 0;
            while( x != 0){
                rev= rev*10 + x % 10;
                x= x/10;
                if( rev > Integer.MAX_VALUE || rev < Integer.MIN_VALUE)
                    return 0;
            }
            return (int) rev;
        }
         */
    }
}
