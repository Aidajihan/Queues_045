﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_045
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*initializing the values of the variables REAR and FRONT to -1 to indicate that 
             * the name is initially empty,*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*This statement check for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1 ) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* this following statements checks whether the queue is empty if the queue
             *  , them the value of the REAR and FRONT variabels is set to 0 */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last  positions of the array, them the value of
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at the last position, them its value is incremented by one. */
                    REAR = REAR + 1;

            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /* Checks weather the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\n The Element deleted from the queue is : " + queue_array[FRONT] + "\n");
            /*Check if the queue has one element. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /*if the element to be deleted is the last position of the array, them the value 
                 * of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1) 
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1; 

            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;  
            /*checks if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
