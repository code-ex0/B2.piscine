using System;

namespace CSharpDiscovery.Quest02
{
    public class DifferenceInMinutes_Exercice
    {
        public static double DifferenceInMinutes(DateTime start, DateTime end)
        {
            TimeSpan timeInMinute = end - start;
//             timeInMinute < 0 ? timeInMinute * (-1) : timeInMinute * 1;
            return timeInMinute.TotalMinutes;
        }
    }
}