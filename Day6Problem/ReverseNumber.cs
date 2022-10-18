using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problem
{
    public class ReverseNumber
    {
        public int RN;

        public ReverseNumber(int rN)
        {
            RN = rN;
        }
        public void CalculateReverseNumber()
        {
            int reverse = 0, rem;

            while (RN != 0)
            {
                rem = RN % 10;
                reverse = (reverse * 10) + rem;
                RN /= 10;
            }
            Console.WriteLine("Reverse Number is : " + reverse);
        }

    }
}
// Reverse Number
