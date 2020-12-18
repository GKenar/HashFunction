using System;
using HashFunction.MathStructures.Exceptions;

namespace HashFunction.MathStructures
{
    class Quasigroup
    {
        private readonly int[,] _cayleyTable;
        private readonly int _n;
        private readonly Random _rnd = new Random();
        private bool _initialized;

        /// <summary>
        /// Конструктор для создания квазигруппы
        /// </summary>
        /// <param name="n">порядок квазигруппы</param>
        public Quasigroup(int n)
        {
            _cayleyTable = new int[n, n];
            _n = n;

            FillCayleyTableWithInvalidValues();
        }

        public void ApplyNewCayleyTable(int[,] newCayleyTable)
        {
            if (newCayleyTable.GetLength(0) != _n || newCayleyTable.GetLength(1) != _n)
                throw new CayleyTableWrongSizeException();

            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    if(newCayleyTable[i, j] < 0 || newCayleyTable[i, j] >= _n)
                        throw new CayleyTableWrongElementException();

                    if (!IsElementUniqueInRowAndColumn(newCayleyTable, i, j))
                        throw new CayleyTableWrongElementException();
                }
            }

            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    _cayleyTable[i, j] = newCayleyTable[i, j];
                }
            }

            _initialized = true;
        }

        public int DoOperation(int operand1, int operand2)
        {
            if(!_initialized)
                throw new QuasigroupIsNotInitializedException();

            if (operand1 < 0 || operand1 >= _n)
                throw new ArgumentOutOfQuasigroup(nameof(operand1));

            if (operand2 < 0 || operand2 >= _n)
                throw new ArgumentOutOfQuasigroup(nameof(operand2));

            return _cayleyTable[operand1, operand2];
        }

        public int[,] GetCayleyTable()
        {
            var cayleyTableClone = new int[_n, _n];

            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    cayleyTableClone[i, j] = _cayleyTable[i, j];
                }
            }

            return cayleyTableClone;
        }

        public int GetQuasigroupOrder()
        {
            return _n;
        }

        public void FillCayleyTableWithRandomValues()
        {
            var shift = 0;
            var arr = new int[_n];

            for (var i = 0; i < _n; i++)
            {
                arr[i] = GenerateUniqueValueInArray(arr, i);
            }

            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    _cayleyTable[i, j] = arr[(j + shift) % _n];
                }
                shift++;
            }

            _initialized = true;
        }

        private int GenerateUniqueValueInArray(int[] array, int elementsCount)
        {
            int rndValue;
            bool retry;

            do
            {
                retry = false;
                rndValue = _rnd.Next(_n);

                for (var j = 0; j < elementsCount; j++)
                {
                    if (array[j] == rndValue)
                        retry = true;
                }
            } while (retry);

            return rndValue;
        }

        private void FillCayleyTableWithInvalidValues()
        {
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    _cayleyTable[i, j] = -1;
                }
            }
        }

        private bool IsElementUniqueInRowAndColumn(int[,] array, int row, int column)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (i != row && array[i, column] == array[row, column])
                    return false;
            }

            for (var j = 0; j < array.GetLength(1); j++)
            {
                if (j != column && array[row, j] == array[row, column])
                    return false;
            }
            return true;
        }
    }
}
