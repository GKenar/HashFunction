using System;
using System.Collections.Generic;
using System.Linq;

namespace HashFunction.ModelComponents
{
    static class OrderIndexesToIdsConvertor
    {
        public static List<int> Convert(List<int> order, List<QuasigroupWithIds> quasigroups)
        {
            return order.Select(item => quasigroups.FindIndex(q => q.Id == item)).ToList();
        }
    }
}
