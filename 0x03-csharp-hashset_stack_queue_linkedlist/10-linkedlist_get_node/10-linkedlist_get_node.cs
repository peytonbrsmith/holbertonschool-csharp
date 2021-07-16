using System;
using System.Collections.Generic;
class LList {
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Get nth node from head
        LinkedListNode<int> node = myLList.First;
        
        int i;
        
        for (i = 0; i < n; i++)
        {
            node = node.Next;
        }
        if (node.Next == null)
        {
            return 0;
        }
        return node.Value;
    }
}