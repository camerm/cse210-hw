using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures Lecture1 = new Lectures("University Lecture", "Mathematical Social lecture", "15-02-2023", "15:00", "av salaverry 308 huaranguillo", "university activity", "Oliverio Cameron", 20);
        Console.WriteLine(Lecture1.FullDetails());
    }
}