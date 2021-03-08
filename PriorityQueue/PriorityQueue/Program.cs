using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue pq = new PriorityQueue(15);

            Node n1 = new Node(1234, "B");
            Node n2 = new Node(2345, "B");
            Node n3 = new Node(3456, "B");

            Node n4 = new Node(4567, "D");
            Node n5 = new Node(1234, "D");
            Node n6 = new Node(1234, "D");
            Node n7 = new Node(1234, "D");

            Node n8 = new Node(1234, "A");
            Node n9 = new Node(1234, "A");

            pq.Enqueue(n1);
            pq.Enqueue(n2);
            pq.Enqueue(n3);
            pq.Enqueue(n4);
            pq.Enqueue(n5);
            pq.Enqueue(n6);
            pq.Enqueue(n7);
            pq.Enqueue(n8);
            pq.Enqueue(n9);

            //Print the queue in order of priority(highest priority first)
        }
    }
}
