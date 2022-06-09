using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(IEnumerable<int> tab, int value)
        {
            return tab?.Contains(value) ?? false;
        }
    }
}