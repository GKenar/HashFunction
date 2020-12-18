using System.Collections.Generic;
using HashFunction.MathStructures;

namespace HashFunction.ModelComponents
{
    interface IModel
    {
        void AddQuasigroup(int order);
        void RemoveQuasigroupByIndex(int index);
        void FillQuasigroupCayleyTableWithRandom(int index);
        void FillQuasigroupCayleyTableWithData(int index, int[,] data);
        void RemoveAllQuasigroups();
        void SetStartValue(int startValue);
        void SetQuasigroupsOperationsOrder(List<List<int>> order);
        int[] GenerateQuasigroupsOperationsOrder();
        string Hash(string text);
        Quasigroup GetQuasigroupByIndex(int index);
        List<int> GetListOfQuasigroupsIds();
    }
}
