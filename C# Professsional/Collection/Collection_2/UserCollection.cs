using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Collection.Collection_2
{
    public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        readonly T[] elements = new T[4];
        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }
        int position = -1;

        bool IEnumerator.MoveNext()
        {
            if ( position < elements.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current => elements[position];
        T IEnumerator<T>.Current => elements[position];
        IEnumerator IEnumerable.GetEnumerator() 
        {
            return this;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }
        void IDisposable.Dispose()
        {
            ((IEnumerator)this).Reset();
        }
    }
}
