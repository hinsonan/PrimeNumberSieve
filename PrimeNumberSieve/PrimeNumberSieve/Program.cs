using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSieve
{

    class Program
    {
        public static void Prime(int min, int max)
        {
            //this count will be used in the algorithm later
            int count = 1;
            //initialize varibles needed           

            //initializes a LinkedList to hold the values of all the number
            LinkedList<int> list = new LinkedList<int>();

            //put all numbers in range into a list
            for (int i = 2; i < max; i++)
            {
                if (i == 2)
                {
                    list.AddFirst(2);
                }
                else
                {
                    list.AddLast(i);
                }

            }

            //does not exceed the sqrt of the upper bound
            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                for (int j = i * i; j < max; j = (i * i) + (count * i))
                {
                    list.Remove(j);

                    //makes the count go up to follow the algorithm i^2 + 2i etc... except on the first iteration
                    if (j != 4)
                    {
                        count += 1;
                    }


                }


            }
            //print out the prime numbers in the list
            foreach (int element in list)
            {
                if (element > min)
                {
                    Console.WriteLine(element);
                }

            }


        }
        static void Main(string[] args)
        {
            int min;
            int max;
            string response;

            //get the min value and validate input
            do
            {
                Console.Write("Enter min: ");
                response = Console.ReadLine();

            }
            while (!int.TryParse(response, out min));




            //get the max and validate input
            do
            {
                Console.Write("Enter max: ");
                response = Console.ReadLine();

            }
            while (!int.TryParse(response, out max));

            //check if max is bigger than min
            if (min > max)
            {
                Console.Write("The min value is higher than the max please restart the program");
                return;

            }
            //calls the Prime function
            Prime(min, max);

            //closes the program at keystroke
            Console.ReadLine();
        }
    }
}