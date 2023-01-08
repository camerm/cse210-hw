using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is yor grade?:");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string score = "";

        if (number >= 90)
        {
            score = "A";
        }
        else if (number >= 80)
        {
            score = "B";
        }
        else if (number >= 70)
        {
            score = "C";
        }
        else if (number >= 60)
        {
            score = "D";
        }
        else
        {
            score = "F";
        }

        Console.WriteLine($"Your grade is {score}");


        // Messages for pass or not pass
        if (number >= 70)
        {
            Console.WriteLine("Congratulations You passed!");
        }
        else
        {
            Console.WriteLine("sorry. Better luck next time!");
        }
    }
}