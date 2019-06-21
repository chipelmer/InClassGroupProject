using System;
using System.Collections.Generic;

namespace InClassGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            // Add all the students
            students.Add("Brandon W. Dowds");


            Random random = new Random();
            int randomNumber = random.Next(0, students.Count);

            Console.WriteLine(students[randomNumber]);
        }
    }
}
