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
            students.Add("Chris Anderson");
            students.Add("Tanner D. Riddle");
            students.Add("Philip Kanellopoulos");
            students.Add("Lee M. Wolfe");

            Random random = new Random();
            int randomNumber = random.Next(0, students.Count);

            Console.WriteLine(students[randomNumber]);
        }
    }
}
