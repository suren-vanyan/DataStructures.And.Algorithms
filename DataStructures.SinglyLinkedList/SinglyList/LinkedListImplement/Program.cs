using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplement
{
    class LinkedList<T>:IEnumerable<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;

        public int Count { get; private set; }

        public void Add(T value)
        {

            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (head == null)
            {
                head = node;
                tail = node;
            }

            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(item)) //Determines whether the specified object is equal to the current object.
                {

                    if (previous != null)
                    {
                        //before
                        // head
                        // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+
                        // | 12  |  *---+--->| 15  |   *--+--->| 20  |  *--+--->| 25  |  *--+--->
                        // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+

                        previous.Next = current.Next;

                        // after
                        // head
                        // +-----+------+    +-----+------+                     +-----+-----+
                        // | 12  |  *---+--->| 15  |   *--+-------------------->| 25  |  *--+--->
                        // +-----+------+    +-----+------+                     +-----+-----+

                        // end list

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        // Remoe the first element list

                        head = head.Next;

                        // If the list is empty and a single item has been deleted.               

                        if (head == null)
                        {
                            head = null;
                        }
                    }

                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }


        #region Метод Contains возвращает значение true, если элемент пренадлежит списку

        public bool Contains(T item)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        #endregion

        #region The Methods gets the Enumerator for collection

        public IEnumerator<T> GetEnumerator()

        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();

        }


        #endregion

        #region The Clear Method clears the list

        public void Clear()
        {
            // The Clear method clears the list by setting _head and _tail to null.
            //Simply remove the links to the items and the garbage collector, erase the list yourself.

           head = null;
            tail = null;
            Count = 0;
        }


        #endregion

        #region Method CopyTo copies the contents of the list into an array

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        #endregion
    
    }

    class Program
    {
        public static void Display(LinkedList<int> words, string test)
        {
            Console.WriteLine(test);
            foreach (int word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int> { };

            //add items to list
            list.Add(20);
            list.Add(40);
            list.Add(30);
            Display(list, "List");

            list.Remove(30);
            Display(list, "List");


            int[] arr = new int[10];
            list.CopyTo(arr, 2);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
