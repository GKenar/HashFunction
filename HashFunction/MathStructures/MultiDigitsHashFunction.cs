using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFunction.MathStructures
{
    class MultiDigitsHashFunction
    {
        private List<OneDigitHashFunction> _digitHashFunctionsList;

        public MultiDigitsHashFunction()
        {
            _digitHashFunctionsList = new List<OneDigitHashFunction>();
        }

        public void SetOneDigitHashFunctionsList(List<OneDigitHashFunction> list)
        {
            _digitHashFunctionsList = list;
        }

        public string Hash(string text, int startValue)
        {
            var sb = new StringBuilder();

            foreach (var hashFunc in _digitHashFunctionsList)
            {
                sb.Append(hashFunc.Hash(text, startValue));
            }

            return sb.ToString();
        }
    }
}
