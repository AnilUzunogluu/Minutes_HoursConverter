using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesToHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the type you want to convert. Minutes or Hours.");
                string type = Console.ReadLine();
                if (type == "Minutes" ||type == "Minute" || type == "minutes" || type == "mins" || type == "min" || type == "Min"|| type == "Mins" || type == "minute")
                {
                    double min, remainderMin;
                    Console.WriteLine("Please enter number of minutes.");
                    min = double.Parse(Console.ReadLine());
                    if (min >= 0)
                    {
                        remainderMin = min % 60;
                        int hour = (int)min / 60;
                        if (remainderMin == 0)
                        {
                            Console.WriteLine("{0} Minutes is equal to {1} hours.", min, hour);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("{0} Minutes is equal to {1} hours and {2} minutes.", min, hour, remainderMin);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive value.");
                    }
                }
                else if (type == "Hours" || type == "hours" || type == "Hour" || type == "hour")
                {
                    double hour, min;
                    Console.WriteLine("Please enter hours.");
                    hour = double.Parse(Console.ReadLine());
                    if (hour>=0)
                    {
                        min = hour * 60;
                        Console.WriteLine("{0} Hours is equal to {1} minutes.",hour,min);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive value.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter one of the specified types.");
                }
                
               
            }
        }
    }
}
