using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyListNode <T>
    {
        internal T value;
        internal MyListNode<T> prev;
        internal MyListNode<T> next;

        public MyListNode(T value)
        {
            this.value = value;
        }
        public MyListNode(MyListNode<T> prev, T value):this(value)
        {
            this.prev = prev;
        }
        public MyListNode(MyListNode<T> prev, MyListNode<T> next, T value) : this(prev, value)
        {
            this.next = next;
        }

    }
}
