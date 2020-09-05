using System;

namespace ControlFlow1
{
    public class Prac1
    {
        static void main(string[] args)
        {

        }

        public void ques1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            var input = Console.Readline();
            var number = Convert.ToInt32(input);
            if (1 <= number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ques2()
        {
            Console.Write("Enter the first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            var max = (input1 > input2) ? input1 : input2;
            Console.WriteLine("Max is: " + max);
        }

        public void ques3()
        {
            Console.Write("Enter width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height of the image");
            var height = Convert.ToInt32(Console.ReadLine());
            var output = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Orientation is: " + output);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public void ques4()
        {
            Console.Write("Enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter speed of the car");
            var carspeed = Convert.ToInt32(Console.ReadLine());

            if (carspeed <= limit)
            {
                Console.WriteLine("OK");
            }

            else if(carspeed > limit)
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carspeed - limit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points are: " + demeritPoints);
                }
            }
        }
    }
}