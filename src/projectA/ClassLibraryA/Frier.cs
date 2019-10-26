using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryA
{
    public class Frier
    {
        public static IEnumerable<string> DoFry(int nuget) =>
            Enumerable.Range(1, nuget).Select(i => $"frying nuget number {i} of {nuget}");            
    }
}
