using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dictionaries!");

            //Make a program similar to GradebookDictionary that does the following:

            //It takes in student names and ID numbers(as integers) instead of names and grades.
            //The keys should be the IDs and the values should be the names.
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Name: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, "")) {
                    Console.WriteLine("ID number: ");
                    input = Console.ReadLine();
                    int newID = int.Parse(input);
                    students.Add(newID, newStudent);

                }
            } while (!Equals(newStudent, ""));
            //Modify the roster printing code accordingly.

            Console.WriteLine("\nClass Roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} : {student.Value}");
            }


        }
    }
}
