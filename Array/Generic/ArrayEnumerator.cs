using System.Collections;

namespace DataStructures.Array.Generic
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int index;
        private int _position;


        public ArrayEnumerator(T[] array, int position)
        {
            _array = array;
            _position = position;
            index = -1;
        }
        public T Current => _array[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _array = null;
        }

        public bool MoveNext()
        {
            if (index < _array.Length - 1)
            {
                index++;
                //_position++;
                //if (_array[index].Equals(_position))
                //{
                //    _array.Take(_position);
                //}
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
