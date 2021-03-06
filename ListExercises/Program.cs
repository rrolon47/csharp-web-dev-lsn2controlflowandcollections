﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            //Write a static method to find the sum of all the even numbers in a List.
            static int Sum(List<int> arg)
            {
                int sum = 0;
                foreach (int num in arg)
                {
                    sum = sum + num;
                }
                return sum;
            }

            //Within Main, create a list with at least 10 integers and call your method on the list.
            List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Sum(newList));

            //Write a static method to print out each word in a list that has exactly 5 letters.
            //Modify your code to prompt the user to enter the word length for the search
            List<string> wordList = new List<string> { "the", "cat", "fight", "blue" };
            
            string greenEggs = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> stringToList = greenEggs.Split(" ").ToList();

            static void LetterWord(List<string> arg)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                double number = double.Parse(input); 
                foreach (string word in arg)
                {
                    if (word.Length == number)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            
            
            LetterWord(wordList);
            LetterWord(stringToList);


            //Bonus
            //https://stackoverflow.com/questions/5011467/convert-string-to-liststring-in-one-line
            //List<string> result = names.Split(',').ToList();

        }
    }
}
