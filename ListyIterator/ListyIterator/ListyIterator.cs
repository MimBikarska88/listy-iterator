using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> _list;
        private int index;

        public ListyIterator(params T[]collection)
        {
            _list = new List<T>(collection);
            index = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext() => index < _list.Count - 1;

        public void Print()
        {
            try
            {
                Console.WriteLine(_list[index]);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new InvalidOperationException("Invalid operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var i in _list)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}