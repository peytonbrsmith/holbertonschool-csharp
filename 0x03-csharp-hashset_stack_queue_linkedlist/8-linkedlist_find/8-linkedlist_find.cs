using System;
using System.Collections.Generic;

class LList {
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        // Find value in list
        LinkedListNode<int> current = myLList.First;

        int index = 0;

        while (current != null)
        {
            if (current.Value == value)
            {
                return index;
            }
            index++;
            current = current.Next;
        }
        return -1;
    }
}