using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    public class Node
    {
        private int jobNumber;
        private string priority;

        public Node() { }

        public Node(int jobNumber, string priority)
        {
            this.jobNumber = jobNumber;
            this.priority = priority;
        }
    }
}
