using System;
using System.Collections;
public static class Queue<T>
{
    private static Stack enQueue = new Stack();
    private static Stack deQueue = new Stack();
    public static void EnQueue(T t)
    {
        /* 
          1) While stack1 is not empty, push everything from stack1 to stack2.
          2) Push x to stack1 (assuming size of stacks is unlimited).
          3) Push everything back to stack1.
        */
        while (enQueue.Count > 0)
        {
            deQueue.Push(enQueue.Pop());
        }
        enQueue.Push(t);
        while (deQueue.Count > 0)
        {
            enQueue.Push(deQueue.Pop());
        }
    }
    public static T DeQueue()
    {
        /* 
            1) If stack1 is empty then error
            2) Pop an item from stack1 and return it
        */
        if (enQueue.Count == 0)
        {
            throw new Exception();
        }
        return (T)enQueue.Pop();
    }
    public static void EnQueue2(T t)
    {
        /*
        1) Push x to stack1 (assuming size of stacks is unlimited).
        */
        enQueue.Push(t);
    }
    public static T DeQueue2()
    {
        /* 
            1) If both stacks are empty then error.
            2) If stack2 is empty
               While stack1 is not empty, push everything from stack1 to stack2.
            3) Pop the element from stack2 and return it.
        */
        if (enQueue.Count == 0 && deQueue.Count == 0)
        {
            throw new Exception();
        }
        if (deQueue.Count == 0)
        {
            while (enQueue.Count > 0)
            {
                deQueue.Push(enQueue.Pop());
            }
        }
        return (T)deQueue.Pop();
    }
    public static void ClearStacks()
    {
        enQueue.Clear();
        deQueue.Clear();
    }
}
