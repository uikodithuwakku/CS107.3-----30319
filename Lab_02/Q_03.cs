using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class TemperatureTracker
    {
        public double[] Temperature = new double[7];

        public void dailyTemp()
        {
            for(int i = 0;i<7;i++)
            {
                Console.Write($"Enter {i+1} day temperature : ");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Report()
        {
            Console.WriteLine("Weekly Teperature Report : "); ;

            for(int i = 0;i<7; i++)
            {
                Console.WriteLine($"Day {i + 1} : Teperature : {Temperature[i]} celcious");
            }
        }
        
    }

    internal class Program
    {
        static void Main()
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.dailyTemp();
            Console.WriteLine("\n");
            tracker.Report();
            Console.Read();

        }
    }
}
