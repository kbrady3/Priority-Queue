using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    public class Node
    {
        public int jobNumber;
        public string priority;

        public Node() { }

        public Node(int jobNumber, string priority)
        {
            if(jobNumber.ToString().Length != 4)
            {
                throw new ArgumentException();
            }
            else
            {
                this.jobNumber = jobNumber;
                this.priority = priority;
            }
        }
    }
}
