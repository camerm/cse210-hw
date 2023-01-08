using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished.");


        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter number:");
            string x = Console.ReadLine();
            userNumber = int.Parse(x);
            
            //Add in the list only the numbers diferent of 0
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }

        //Print all the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}