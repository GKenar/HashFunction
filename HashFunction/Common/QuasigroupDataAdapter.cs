using System;
using HashFunction.MathStructures;

namespace HashFunction.Common
{
    static class QuasigroupDataAdapter
    {
        // ПЕРЕРАБОТАТЬ
        public static string[,] AdaptQuasigroupDataToView(Quasigroup quasigroup)
        {
            var cayleyTable = quasigroup.GetCayleyTable();
            var n = quasigroup.GetQuasigroupOrder();

            var view = new string[n + 1, n + 1];

            view[0, 0] = "*";

            for (var i = 0; i < n; i++)
            {
                view[0, i + 1] = i.ToString();
                view[i + 1, 0] = i.ToString();
            }

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (cayleyTable[i - 1, j - 1] != -1)
                    {
                        view[i, j] = cayleyTable[i - 1, j - 1].ToString();
                    }
                    else
                    {
                        view[i, j] = string.Empty;
                    }
                }
            }

            return view;
        }

        public static int[,] AdaptViewToQuasigroupData(string[,] data)
        {
            var outputData = new int[data.GetLength(0) - 1, data.GetLength(1) - 1];

            for (var i = 0; i < outputData.GetLength(0); i++)
            {
                for (var j = 0; j < outputData.GetLength(1); j++)
                {
                    outputData[i, j] = Convert.ToInt32(data[i + 1, j + 1]);
                }
            }

            return outputData;
        }
    }
}
