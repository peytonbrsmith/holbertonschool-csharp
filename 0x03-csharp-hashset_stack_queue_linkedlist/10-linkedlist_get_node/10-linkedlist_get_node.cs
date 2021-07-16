using System;
using System.Collections.Generic;
class LList {
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Get nth node from list
        LinkedListNode<int> node = myLList.First;
        int count = 0;
        while (node != null)
        {
            if (count == n)
            {
                return node.Value;
            }
            node = node.Next;
            count++;
        }
        return 0;
    }
}