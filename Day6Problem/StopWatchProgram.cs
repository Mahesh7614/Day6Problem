using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problem
{
    public class StopWatchProgram
    {
        public void CalculateStopWatchTime()
        {
            int s = 0;
            int m = 0;
            int h = 0;
            for (s = 0; s <= 59; s++)
            {
                Console.WriteLine("Second: {0}", s);
                if (s == 59)
                {
                    m = 1;
                    while (m <= 59)
                    {
                        for (s = 0; s <= 59; s++)
                        {
                            Console.WriteLine(m + ":" + s);

                        }

                        m++;
                    }
                    m = 59;
                    // Console.WriteLine("Minute: " + m+ ":"+ s);
                    if (m == 59)
                    {
                        h = 1;
                        while (h <= 24)
                        {
                            //Console.WriteLine("Hour :" + h);
                            m = 1;
                            while (m <= 59)
                            {
                                //Console.WriteLine("Minute :" + m);

                                for (s = 0; s <= 59; s++)
                                {
                                    Console.WriteLine(h + ":" + m + ":" + s);
                                }
                                m++;
                            }
                            h++;
                        }
                    }

                }
            }
        }
    }
}

