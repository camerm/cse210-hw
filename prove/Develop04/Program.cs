using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        
        List <string> menu = new List<string>
        {
        "Menu option:",
        "1. Start Beathing Activity",
        "2. Start Refleacting Activity",
        "3. Start Listening",
        "4. Quit",
        };


        while (menuInput != 4)
        {
            Console.Clear();
            foreach (string menuOption in menu)
            {
                Console.Write(menuOption);                
            }
            Console.Write("Select a option from the menu");
            menuInput = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        switch (menuInput)
        {
            case 1:
                break;
            case 2:
                ReflectingActivity demo = new ReflectingActivity();
                demo.runActivity();
                break;
        }
        

    }
}