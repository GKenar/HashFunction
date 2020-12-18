using System.Collections.Generic;
using System;
using HashFunction.MathStructures.Exceptions;

namespace HashFunction.MathStructures
{
    class OneDigitHashFunction
    {
        private List<Quasigroup> _quasigroupsList;
        private List<int> _quasigroupsOrder;

        public OneDigitHashFunction()
        {
            _quasigroupsList = new List<Quasigroup>();
            _quasigroupsOrder = new List<int>();
        }

        public void SetQuasigroupsList(List<Quasigroup> list)
        {
            _quasigroupsList = list;
        }

        public void SetQuasigroupsOrder(List<int> list)
        {
            _quasigroupsOrder = list;
        }

        public int Hash(string text, int startValue)
        {
            if (_quasigroupsList.Count == 0)
                throw new EmptyQuasigroupsListException();

            if (_quasigroupsOrder.Count == 0)
                throw new EmptyQuasigroupsOrderListException();

            if (startValue == -1)
                throw new StartValueIsNotInitializedException();

            var hashValue = startValue;
            var m = _quasigroupsOrder.Count;
            var k = 0;

            try
            {
                foreach (var c in text)
                {
                    var textValue = Convert.ToInt32(c.ToString());

                    hashValue = _quasigroupsList[_quasigroupsOrder[k]].DoOperation(hashValue, textValue);
                    k = (k + 1) % m;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new QuasigroupIndexOutOfListException();
            }

            return hashValue;
        }
    }
}
