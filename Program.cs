using System;

namespace In_class_9_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your grades for your 4 classes: ");
            int[] grade = new int[5];
            grade[1] = int.Parse(Console.ReadLine());
            grade[2] = int.Parse(Console.ReadLine());
            grade[3] = int.Parse(Console.ReadLine());
            grade[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
         
            if (grade[1] > 90)
                Console.WriteLine("you got an A!!!");
            else if (grade[1] < 89 && grade[1] > 80)
                Console.WriteLine("you get a B");
            else if (grade[1] < 79 && grade[1] > 70)
                Console.WriteLine("you get a C");
            else if (grade[1] < 69 && grade[1] > 60)
                Console.WriteLine("you get a D");
            else if (grade[1] < 59)
                Console.WriteLine("you get a F");

            if (grade[2] > 90)
                Console.WriteLine("you got an A!!!");
            else if (grade[2] < 89 && grade[2] > 80)
                Console.WriteLine("you get a B");
            else if (grade[2] < 79 && grade[2] > 70)
                Console.WriteLine("you get a C");
            else if (grade[2] < 69 && grade[2] > 60)
                Console.WriteLine("you get a D");
            else if (grade[2] < 59)
                Console.WriteLine("you get a F");

            if (grade[3] > 90)
                Console.WriteLine("you got an A!!!");
            else if (grade[3] < 89 && grade[3] > 80)
                Console.WriteLine("you get a B");
            else if (grade[3] < 79 && grade[3] > 70)
                Console.WriteLine("you get a C");
            else if (grade[3] < 69 && grade[3] > 60)
                Console.WriteLine("you get a D");
            else if (grade[3] < 59)
                Console.WriteLine("you get a F");

            if (grade[4] > 90)
                Console.WriteLine("you got an A!!!");
            else if (grade[4] < 89 && grade[4] > 80)
                Console.WriteLine("you get a B");
            else if (grade[4] < 79 && grade[4] > 70)
                Console.WriteLine("you get a C");
            else if (grade[4] < 69 && grade[4] > 60)
                Console.WriteLine("you get a D");
            else if (grade[4] < 59)
                Console.WriteLine("you get a F"); 

        }
    }
}
