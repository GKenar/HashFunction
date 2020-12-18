using System;
using System.Collections.Generic;
using System.Linq;
using HashFunction.MathStructures;

namespace HashFunction.ModelComponents
{
    class Model : IModel
    {
        private readonly List<QuasigroupWithIds> _quasigroupsList;
        private readonly MultiDigitsHashFunction _hashFunction;
        private List<List<int>> _quasigroupsOperationsOrderList;
        private int _nextId;
        private int _startValue;

        public Model()
        {
            _quasigroupsList = new List<QuasigroupWithIds>();
            _quasigroupsOperationsOrderList = new List<List<int>>();
            _hashFunction = new MultiDigitsHashFunction();
            _nextId = 1;
            _startValue = -1;
        }

        public string Hash(string text)
        {
            var quasigroupsList = _quasigroupsList.Select(item => item.Quasigroup).ToList();

            var oneDigitFunctionsList = _quasigroupsOperationsOrderList.Select(order =>
            {
                var oneDigitFunc = new OneDigitHashFunction();
                oneDigitFunc.SetQuasigroupsList(quasigroupsList);
                oneDigitFunc.SetQuasigroupsOrder(OrderIndexesToIdsConvertor.Convert(order, _quasigroupsList));

                return oneDigitFunc;
            }).ToList();

            /*
            var oneDigitFunc = new OneDigitHashFunction();
            oneDigitFunc.SetQuasigroupsList(_quasigroupsList.Select(item => item.Quasigroup).ToList());
            oneDigitFunc.SetQuasigroupsOrder(_quasigroupsList.Select((item, index) => index).ToList());
            */
            _hashFunction.SetOneDigitHashFunctionsList(oneDigitFunctionsList);
            
            return _hashFunction.Hash(text, _startValue);
        }

        public void AddQuasigroup(int order)
        {
            if (order < 1 || order > 10)
                throw new ArgumentOutOfRangeException(nameof(order));

            _quasigroupsList.Add(new QuasigroupWithIds() { Id = _nextId++, Quasigroup = new Quasigroup(order) });
        }

        public void RemoveQuasigroupByIndex(int index)
        {
            _quasigroupsList.RemoveAt(index);
        }

        public void FillQuasigroupCayleyTableWithRandom(int index)
        {
            if (index < 0 || index >= _quasigroupsList.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            _quasigroupsList[index].Quasigroup.FillCayleyTableWithRandomValues();
        }

        public void FillQuasigroupCayleyTableWithData(int index, int[,] data)
        {
            if (index < 0 || index >= _quasigroupsList.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            _quasigroupsList[index].Quasigroup.ApplyNewCayleyTable(data);
        }

        public void RemoveAllQuasigroups()
        {
            _quasigroupsList.Clear();
            _nextId = 1;
        }

        public void SetStartValue(int startValue)
        {
            _startValue = startValue;
        }

        public void SetQuasigroupsOperationsOrder(List<List<int>> order)
        {
            _quasigroupsOperationsOrderList = order;
        }

        public Quasigroup GetQuasigroupByIndex(int index)
        {
            return _quasigroupsList[index].Quasigroup;
        }

        public List<int> GetListOfQuasigroupsIds()
        {
            return _quasigroupsList.Select(item => item.Id).ToList();
        }

        public int[] GenerateQuasigroupsOperationsOrder()
        {
            return OperationsOrderGenerator.Generate(_quasigroupsList);
        }
    }
}
