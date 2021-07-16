using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = null;
        // insert a node in order of the linked list
        LinkedListNode<int> current = myLList.First;
        if (myLList.Count == 0)
        {
            newNode = myLList.AddFirst(n);
        }
        else
        {
            while (current.Next != null)
            {
                if (current.Value > n)
                {
                    break;
                }
                current = current.Next;
            }
            newNode = myLList.AddBefore(current, n);
        }
        return newNode;
    }
}