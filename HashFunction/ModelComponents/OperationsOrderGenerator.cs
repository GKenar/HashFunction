using System;
using System.Collections.Generic;

namespace HashFunction.ModelComponents
{
    static class OperationsOrderGenerator
    {
        public static int[] Generate(List<QuasigroupWithIds> list)
        {
            var indexes = new int[list.Count];
            var rnd = new Random();

            foreach (var item in list)
            {
                var id = item.Id;
                while (true)
                {
                    var rndPos = rnd.Next(list.Count);

                    if (indexes[rndPos] != 0)
                        continue;

                    indexes[rndPos] = id;
                    break;
                }
            }

            return indexes;
        }
    }
}
