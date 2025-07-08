using System;
using System.Collections;

namespace Collection.Collection
{
    public class UserCollection : IEnumerable, IEnumerator
    {
        readonly Element[] elements = new Element[4];
        public Element this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }
        int position = -1;
        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => elements[position];

        IEnumerator IEnumerable.GetEnumerator() 
        {
            return (IEnumerator) this;
        }          
    }
}
