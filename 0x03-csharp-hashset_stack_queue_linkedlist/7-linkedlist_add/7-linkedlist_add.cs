using System;
using System.Collections.Generic;

class LList  {
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Create a new node and add it to the beginning of muyLList
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        myLList.AddFirst(newNode);
        return newNode;
    }
}