/**************************************************************
* Name        : QueueLab
* Author      : Kabrina Brady
* Created     : 2/14/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows XX
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        // Members
        private int head;    // The index of item at the top of the queue
        private int tail;    // The index of item at the bottom of the queue
        private int queueSize;    // The number of items in the queue
        private int maxSize; // The max number of items the queue can contain
        private Node[] stackItems;

        public PriorityQueue()
        {
            this.maxSize = 5;
            this.queueSize = 0;
            this.head = -1;
            this.tail = -1;
            this.stackItems = new Node[maxSize];
        }

        public PriorityQueue(int maxSize)
        {
            this.maxSize = maxSize;
            this.queueSize = 0;
            this.head = -1;
            this.tail = -1;
            this.stackItems = new Node[maxSize];
        }

        public int SetHead()
        {
            head = maxSize - 1;
            return head;
        }

        public string Dequeue()
        {
            SetHead();

            if (stackItems[0] == null)
            {
                throw new Exception("Empty");
            }
            else
            {
                Node itemAtHead = stackItems[head];
                stackItems[head] = null;
                return itemAtHead.ToString(); //Return item that was dequeued
            }
        }

        public void Enqueue(Node item)
        {
            if (stackItems[0] == null)
            {
                stackItems[0] = item;
            }
            else if (stackItems[maxSize - 1] == null) //Checks if the last slot in the array is empty
            {
                Node[] tempArray = new Node[maxSize];

                //Array.Copy(originalArray, startIndex, newArray, startIndex, endIndex);
                Array.Copy(stackItems, 0, tempArray, 1, maxSize - 1); //Copies stackItems objects into tempArray, starting at index 1

                stackItems = tempArray;

                stackItems[0] = item;
            }
            else
            {
                throw new Exception("Full");
            }
        }
    }
}