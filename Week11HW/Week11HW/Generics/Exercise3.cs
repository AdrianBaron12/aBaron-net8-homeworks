using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11HW.Generics
{
    public class MyQueue<T>
    {
        /// <summary>
        /// Create a generic class that represents a queue, where the items can be of any type.
        /// The class should have methods to enqueue, dequeue, and peek at the front item, as well as a method to check if the queue is empty.
        /// </summary>

        List<T> queueIdentifier = new List<T>();

        public MyQueue()
        {

        }

        public void Enqueue(T item)
        {
            queueIdentifier.Add(item);
        }

        public T Dequeue()
        {
            if(queueIdentifier.Count < 0)
            {
                throw new Exception("Queue is empty");
            }

            T dequeueItem = queueIdentifier[0];
            queueIdentifier.RemoveAt(0);
            return dequeueItem;
        }

        public T Peek
        {
            get
            {
                if (queueIdentifier.Count > 0)
                {
                    return queueIdentifier[0];
                }

                throw new Exception();
            }
        }

        public bool IsEmpty()
        {
            return queueIdentifier.Count == 0;
        }

        ///the code below is a try for Array alternative

        //    private T[] _store;
        //    private int _head=0;
        //    private int _tail=0;
        //    private int _items;



        //    public MyQueue(int capacity)
        //    {
        //        _store = new T[capacity];
        //    }

        //    public void Enqueue(T key)
        //    {
        //        _items++;
        //        _store[_tail] = key;
        //    }

        //    public T Dequeue()
        //    {
        //        T headItem;
        //        headItem = _store[_head];
        //        if (headItem != null)
        //        {
        //            _items--;
        //        }
        //        return headItem;
        //    }

        //public T Peek
        //    {
        //        get
        //        {
        //            return _store[_head];
        //        }
        //    }
        //    public bool IsEmpty()
        //    {
        //        return _tail == 0;
        //    }


        //    }
    }
}
