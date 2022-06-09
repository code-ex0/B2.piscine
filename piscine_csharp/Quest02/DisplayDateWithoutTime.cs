using System;

namespace CSharpDiscovery.Quest02
{
    public class DisplayDateWithoutTime_Exercice
    {
        public static string DisplayDateWithoutTime(DateTime date)
        {
            string test= date.ToString("dd/MM/yyyy") ;
            return test;
        }
    }
}