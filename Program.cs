using System;

namespace daily_coding_challanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int>.EnQueue(1);
            Queue<int>.EnQueue(2);
            Queue<int>.EnQueue(3);
            Console.WriteLine(Queue<int>.DeQueue());
            Queue<int>.EnQueue(4);
            Console.WriteLine(Queue<int>.DeQueue());
            Queue<int>.EnQueue(5);
            Console.WriteLine(Queue<int>.DeQueue());
            Queue<int>.EnQueue(6);
            Queue<int>.EnQueue(7);
            Console.WriteLine(Queue<int>.DeQueue());

            Queue<int>.ClearStacks();

            Queue<int>.EnQueue2(1);
            Queue<int>.EnQueue2(2);
            Queue<int>.EnQueue2(3);
            Console.WriteLine(Queue<int>.DeQueue2());
            Queue<int>.EnQueue2(4);
            Console.WriteLine(Queue<int>.DeQueue2());
            Queue<int>.EnQueue2(5);
            Console.WriteLine(Queue<int>.DeQueue2());
            Queue<int>.EnQueue2(6);
            Queue<int>.EnQueue2(7);
            Console.WriteLine(Queue<int>.DeQueue2());
        }
    }
}
