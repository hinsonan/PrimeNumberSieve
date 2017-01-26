using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSieve
{

    class Program
    {
        public static void Prime()
        {
            int count = 1;
            //get the lower bound
            Console.WriteLine("Enter the Lower Bound Number: ");

            //validate that the user put in an int
            int lowerBound = int.Parse(Console.ReadLine());

            //get the upper bound
            Console.WriteLine("Enter Upper Bound Number: ");

            int upperBound = int.Parse(Console.ReadLine());

            //initializes an array with the size of the amount of numbers between the lower and upper bound
            LinkedList<int> list = new LinkedList<int>();



            //put all numbers in range into a list
            for (int i = 2; i < upperBound; i++)
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
            for (int i = 2; i < Math.Sqrt(upperBound); i++)
            {
                for (int j = i * i; j < upperBound; j = (i * i) + (count * i))
                {
                    //Console.WriteLine("this number is being deleted " + j);

                    list.Remove(j);

                    //makes the count go up to follow the algorithm i^2 + 2i etc...
                    if (j != 4)
                    {
                        count += 1;
                    }


                }


            }
            foreach (int element in list)
            {
                if (element > lowerBound)
                {
                    Console.WriteLine(element);
                }

            }


        }
        static void Main(string[] args)
        {
            //calls the Prime function
            Prime();
        }
    }
}