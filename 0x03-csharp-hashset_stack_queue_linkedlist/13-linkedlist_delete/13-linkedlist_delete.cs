using System;
using System.Collections.Generic;

class LList{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i <= index && currentNode != null; i++)
        {
            if (i != index)
            {
                currentNode = currentNode.Next;
                continue;
            }

            myLList.Remove(currentNode);
        }
    }
}