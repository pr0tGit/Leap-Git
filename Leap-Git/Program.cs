using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsLeapYear(1996));
            Console.ReadLine();
        }

        public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

            return false;
        } // end of IsLeapYear method
    }
}
