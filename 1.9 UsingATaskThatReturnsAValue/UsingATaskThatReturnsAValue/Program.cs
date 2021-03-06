﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingATaskThatReturnsAValue
{
    class Program
    {
        public static void Main()
        {
            //Next to Task, the.NET Framework also has the Task< T > class that you can use if a 
            //Task should return a value.
             Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            //Attempting to read the Result property on a Task will force the thread that’s trying to read the 
            //result to wait until the Task is finished before continuing. As long as the Task has not finished, 
            //it is impossible to give the result. If the Task is not finished, this call will block the 
            //current thread.
            Console.WriteLine(t.Result); // Displays 42
            Console.ReadKey();
        }
    }
}
