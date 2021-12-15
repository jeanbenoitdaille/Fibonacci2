    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
           public static int Fibonacci(int position) 
           {
                if(position <= 2) {
                    return 1;
                } else {
                    return Fibonacci(position - 2) + Fibonacci(position - 1);
                }
           }
        }
    }