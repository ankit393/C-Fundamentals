using System;

namespace ControlFlow2
{
    class Program
    {
        static void main(string[] args)
        {
            
        }

        public void ques1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void ques2()
        {

        }
    }
}