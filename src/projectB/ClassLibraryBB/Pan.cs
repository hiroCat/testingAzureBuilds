using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryBB
{
    public class Pan
    {
            public static IEnumerable<string> DoPutInThaPan(int steak) =>
                Enumerable.Range(1, steak).Select(i => $" {i}  steack in the pan , of {steak}");
    }
}
