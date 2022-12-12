using System;
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
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
