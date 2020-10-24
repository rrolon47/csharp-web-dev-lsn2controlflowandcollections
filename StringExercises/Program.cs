using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            //create string
            string greenEggs = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            
            //split at spaces to create array
            string[] greenEggsArray = greenEggs.Split(" ");

            //print array 
            Console.WriteLine(string.Join(" ", greenEggsArray));

            //repeat to separate the sentances
            string[] greenEggsArray2 = greenEggs.Split(".");
            Console.WriteLine(string.Join(".", greenEggsArray2));
        }
    }
}
