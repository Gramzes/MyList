using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyList <T>
    {
        MyListNode<T> First;
        MyListNode<T> Last;
        public int Count { 
            get
            {
                int k = 0;
                if (First == null)
                {
                    return k;
                }
                MyListNode<T> current = First;
                while (current!=null)
                {
                    current = current.next;
                    k++;
                }
                return k;
            }
        }

        public T this[int k] 
        {
            get
            {
                MyListNode<T> current = First;
                for (int i = 0; i < k; i++)
                {
                    current = current.next;
                }
                return current.value;
            }
            set
            {
                int currentCount = Count;
                if (currentCount < k)
                {
                    throw new Exception("Выход за рамки списка");
                }
                else if (k == 0)
                {
                    MyListNode<T> newNode = new MyListNode<T>(null, First, value);
                    First.prev = newNode;
                    First = newNode;
                }
                else if (k == currentCount)
                {
                    MyListNode<T> newNode = new MyListNode<T>(Last, value);
                    Last.next = newNode;
                    Last = newNode;
                }
                else
                {
                    MyListNode<T> current = First;
                    for (int i = 0; i < k; i++)
                    {
                        current = current.next;
                    }
                    MyListNode<T> prevCurrent = current.prev;
                    MyListNode<T> newNode = new MyListNode<T>(prevCurrent, current, value);
                    prevCurrent.next = newNode;
                    current.prev = newNode;
                }
            }
        }

        public void Add(T value)
        {
            if (First != null && Last!=null)
            {
                MyListNode<T> current = new MyListNode<T>(Last, value);
                Last.next = current;
                Last = current;
            }
            else if (First == null)
            {
                First = new MyListNode<T>(value);
            }
            else
            {
                Last = new MyListNode<T>(First, value);
                First.next = Last;
            }
        }

        public void Remove(int index)
        {
            int currentCount = Count;
            if (currentCount - 1 < index)
            {
                throw new Exception("Выход за рамки списка");
            }
            else if (index == 0)
            {
                First.next.prev = null;
                First = First.next;
            }
            else if (index == currentCount - 1)
            {
                Last.prev.next = null;
                Last = Last.prev;
            }
            else
            {
                MyListNode<T> current = First;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                MyListNode<T> prevCurrent = current.prev;
                MyListNode<T> nextCurrent = current.next;
                prevCurrent.next = nextCurrent;
                nextCurrent.prev = prevCurrent;
            }
        }
        public void Clear()
        {
            First = null;
            Last = null;
        }
    }
}
