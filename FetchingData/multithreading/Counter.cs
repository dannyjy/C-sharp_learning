using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FetchingData.multithreading
{
    class Counter
    {
        private int count = 0;
        private readonly object locker = new object();

        public void Increment()
        {
            lock (locker)
            {
                for (int i = 1; i <= 5; i++)
                {
                    count = count + i;
                    Console.WriteLine("Count: " + count);
                }
            }
        }
    }
}