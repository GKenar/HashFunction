using System;
using System.Collections.Generic;
using System.Linq;

namespace HashFunction.Common
{
    static class OperationsOrderDataAdapter
    {
        public static List<List<int>> Adapt(List<string> data)
        {
            var ordersList = new List<List<int>>();

            foreach (var item in data)
            {
                var order = item.Split(',').Select(x => Convert.ToInt32(x)).ToList();
                ordersList.Add(order);
            }

            return ordersList;
        }
    }
}
