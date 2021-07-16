using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        //Create a new node
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        //If the list is empty, the new node is the first node
        if (myLList.First == null)
        {
            myLList.AddFirst(newNode);
        }
        //If the list is not empty, insert into the sorted linked list
        else
        {
            LinkedListNode<int> current = myLList.First;
            while (current.Next != null)
            {
                if (n < current.Next.Value)
                {
                    myLList.AddBefore(current, newNode);
                    break;
                }
                current = current.Next;
            }
            if (current.Next == null)
            {
                myLList.AddLast(newNode);
            }
        }
        return newNode;
    }
}